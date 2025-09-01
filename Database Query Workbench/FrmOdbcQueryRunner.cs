using System;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseQueryWorkbench.Features.EBBSFilesUpload
{
    public partial class FrmOdbcQueryRunner : Form
    {
        private CancellationTokenSource? _cts;

        public FrmOdbcQueryRunner()
        {
            InitializeComponent();

            // Optional hotkeys
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F5) { btnV1Execute.PerformClick(); e.Handled = true; }
                if (e.Control && e.KeyCode == Keys.L) { btnV1ClearLog.PerformClick(); e.Handled = true; }
            };
        }

        private void FrmOdbcQueryRunner_Load(object sender, EventArgs e)
        {
            // Hide loaders initially
            pBLoadingODBCSQLQuery.Visible = false;
            pBLoadingExecutionLog.Visible = false;
            pBLoadingRecordList.Visible = false;

            // Sample query (remove if not needed)
            if (string.IsNullOrWhiteSpace(richTextODBCSQLQuery.Text))
                richTextODBCSQLQuery.Text = "SELECT 1 AS One;";
        }

        private async void btnV1Execute_Click(object sender, EventArgs e)
        {
            // === Read inputs from your textboxes ===
            string connStr = (txtConnectionString?.Text ?? "").Trim();   // <— change name if yours differs
            string sql = (richTextODBCSQLQuery?.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(connStr))
            {
                AppendLog("WARN", "Connection string is empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(sql))
            {
                AppendLog("WARN", "Query is empty.");
                return;
            }

            int timeoutSec = 120;
            if (int.TryParse(txtTimeoutSec?.Text, out var parsed) && parsed > 0) // <— change name if yours differs
                timeoutSec = parsed;

            // UI state
            btnV1Execute.Enabled = false;
            btnV1Cancel.Enabled = true;
            pBLoadingODBCSQLQuery.Visible = true;
            pBLoadingExecutionLog.Visible = true;
            pBLoadingRecordList.Visible = true;

            dgvV1P2RecordList.DataSource = null;
            lblV1P2Records.Text = "0 : Records";

            _cts = new CancellationTokenSource();
            var sw = Stopwatch.StartNew();

            try
            {
                AppendLog("INFO", "Opening ODBC connection...");
                using var conn = new OdbcConnection(connStr);
                await conn.OpenAsync(_cts.Token);

                using var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandTimeout = timeoutSec;

                // Prefer reader (SELECT). If no result set, fall back to non-query.
                try
                {
                    using var reader = await cmd.ExecuteReaderAsync(_cts.Token);

                    if (!reader.HasRows && reader.FieldCount == 0)
                    {
                        // No result set → DDL/DML path
                        int affected = await ExecuteNonQueryFallback(connStr, sql, timeoutSec, _cts.Token);
                        sw.Stop();
                        AppendLog("INFO", $"Non-query executed. Rows affected: {affected}. Elapsed: {sw.ElapsedMilliseconds} ms.");
                        return;
                    }

                    var dt = new DataTable();
                    dt.Load(reader); // first result set
                    BindResult(dt);
                    dgvV1P2RecordList.DataSource = dt;
                    lblV1P2Records.Text = $"{dt.Rows.Count:n0} : Records";

                    sw.Stop();
                    AppendLog("INFO", $"Loaded {dt.Rows.Count:n0} row(s). Elapsed: {sw.ElapsedMilliseconds} ms.");
                }
                catch (OdbcException ex) when (IsNoResultSet(ex))
                {
                    // Some drivers throw when no result set
                    int affected = await ExecuteNonQueryFallback(connStr, sql, timeoutSec, _cts.Token);
                    sw.Stop();
                    AppendLog("INFO", $"Non-query executed. Rows affected: {affected}. Elapsed: {sw.ElapsedMilliseconds} ms.");
                }
            }
            catch (OperationCanceledException)
            {
                sw.Stop();
                AppendLog("WARN", $"Execution cancelled after {sw.ElapsedMilliseconds} ms.");
            }
            catch (Exception ex)
            {
                sw.Stop();
                AppendLog("ERROR", ex.ToString());
            }
            finally
            {
                _cts?.Dispose();
                _cts = null;

                btnV1Execute.Enabled = true;
                btnV1Cancel.Enabled = false;
                pBLoadingODBCSQLQuery.Visible = false;
                pBLoadingExecutionLog.Visible = false;
                pBLoadingRecordList.Visible = false;
            }
        }

        private void btnV1Cancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void btnV1ClearLog_Click(object sender, EventArgs e)
        {
            txtExecutionLog.Clear();
        }

        // ---- helpers ----
        private static async Task<int> ExecuteNonQueryFallback(string connStr, string sql, int timeoutSec, CancellationToken ct)
        {
            using var conn = new OdbcConnection(connStr);
            await conn.OpenAsync(ct);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandTimeout = timeoutSec;
            return await cmd.ExecuteNonQueryAsync(ct);
        }

        private static bool IsNoResultSet(OdbcException ex)
        {
            var msg = (ex.Message ?? string.Empty).ToLowerInvariant();
            return msg.Contains("no results") ||
                   msg.Contains("no resultset") ||
                   msg.Contains("result set not generated");
        }

        private void AppendLog(string level, string message)
        {
            if (txtExecutionLog.InvokeRequired)
            {
                txtExecutionLog.BeginInvoke(new Action(() => AppendLog(level, message)));
                return;
            }

            Color color = Color.White;
            switch (level.ToUpperInvariant())
            {
                case "INFO":
                    color = Color.LightGreen;
                    break;
                case "WARN":
                    color = Color.Yellow;
                    break;
                case "ERROR":
                    color = Color.OrangeRed;
                    break;
                case "DEBUG":
                    color = Color.LightBlue;
                    break;
            }

            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{level}] {message}{Environment.NewLine}";

            // Move caret to end
            txtExecutionLog.SelectionStart = txtExecutionLog.TextLength;
            txtExecutionLog.SelectionLength = 0;

            // Apply color
            txtExecutionLog.SelectionColor = color;
            txtExecutionLog.AppendText(line);

            // Reset
            txtExecutionLog.SelectionColor = txtExecutionLog.ForeColor;
        }


// --- Add to your form class ---
private bool _gridEventsWired;

    private void BindResult(DataTable dt)
    {
        dgvV1P2RecordList.AutoGenerateColumns = false;
        dgvV1P2RecordList.Columns.Clear();

        foreach (DataColumn dc in dt.Columns)
        {
            DataGridViewColumn col;

            if (dc.DataType == typeof(byte[]))
            {
                // We’ll convert byte[] -> Image at runtime (only if valid)
                col = new DataGridViewImageColumn
                {
                    HeaderText = dc.ColumnName,
                    DataPropertyName = dc.ColumnName,   // still bind to the byte[]
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
            }
            else
            {
                col = new DataGridViewTextBoxColumn
                {
                    HeaderText = dc.ColumnName,
                    DataPropertyName = dc.ColumnName
                };
            }

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvV1P2RecordList.Columns.Add(col);
        }

        dgvV1P2RecordList.DataSource = dt;
        lblV1P2Records.Text = $"{dt.Rows.Count:n0} : Records";

        if (!_gridEventsWired)
        {
            _gridEventsWired = true;

            // Suppress the default popup
            dgvV1P2RecordList.DataError += (s, e) => { e.ThrowException = false; };

            // Convert byte[] to preview image OR fallback text
            dgvV1P2RecordList.CellFormatting += (s, e) =>
            {
                if (e.Value is byte[] bytes)
                {
                    if (bytes.Length == 0)
                    {
                        // empty blob
                        e.Value = "(empty)";
                        e.FormattingApplied = true;
                        return;
                    }

                    // Try fast header check; only then attempt decode
                    if (IsLikelyImage(bytes) && TryDecodeThumbnail(bytes, 256, out var thumb))
                    {
                        e.Value = thumb;            // Image shown in ImageColumn
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        // Not an image → show size text.
                        // If this is an ImageColumn, swap to text by painting cell value as string.
                        // Easiest approach: just set formatted value to size string; grid will render the string.
                        e.Value = $"{bytes.Length:n0} bytes";
                        e.FormattingApplied = true;
                    }
                }
            };

            // Optional: double-click image to view full size
            dgvV1P2RecordList.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (dgvV1P2RecordList.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
                {
                    var dc = drv.Row.Table.Columns[e.ColumnIndex];
                    if (dc.DataType == typeof(byte[]) && drv.Row[e.ColumnIndex] is byte[] blob && blob.Length > 0)
                    {
                        if (TryDecodeImage(blob, out var img))
                        {
                            using (img)
                            using (var viewer = new Form { Text = dc.ColumnName, Width = 900, Height = 700, StartPosition = FormStartPosition.CenterParent })
                            {
                                var pb = new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, Image = (Image)img.Clone() };
                                viewer.Controls.Add(pb);
                                viewer.ShowDialog(this);
                            }
                        }
                    }
                }
            };
        }
    }

    // ---- Helpers: image sniff & safe decode ----

    private static bool IsLikelyImage(byte[] b)
    {
        // PNG 89 50 4E 47
        if (b.Length > 8 && b[0] == 0x89 && b[1] == 0x50 && b[2] == 0x4E && b[3] == 0x47) return true;
        // JPEG FF D8
        if (b.Length > 3 && b[0] == 0xFF && b[1] == 0xD8) return true;
        // GIF 47 49 46
        if (b.Length > 3 && b[0] == 0x47 && b[1] == 0x49 && b[2] == 0x46) return true;
        // BMP 42 4D
        if (b.Length > 2 && b[0] == 0x42 && b[1] == 0x4D) return true;
        // TIFF (II*\0 or MM\0*)
        if (b.Length > 4 && ((b[0] == 0x49 && b[1] == 0x49 && b[2] == 0x2A && b[3] == 0x00) ||
                             (b[0] == 0x4D && b[1] == 0x4D && b[2] == 0x00 && b[3] == 0x2A))) return true;
        // ICO 00 00 01 00
        if (b.Length > 4 && b[0] == 0x00 && b[1] == 0x00 && b[2] == 0x01 && b[3] == 0x00) return true;

        return false;
    }

    private static bool TryDecodeImage(byte[] bytes, out Image? image)
    {
        try
        {
            using var ms = new MemoryStream(bytes, writable: false);
            image = Image.FromStream(ms, useEmbeddedColorManagement: false, validateImageData: true);
            return true;
        }
        catch
        {
            image = null;
            return false;
        }
    }

    private static bool TryDecodeThumbnail(byte[] bytes, int maxEdge, out Image? thumb)
    {
        thumb = null;
        if (!TryDecodeImage(bytes, out var img) || img == null) return false;

        using (img)
        {
            // Scale down proportionally
            var ratio = Math.Max(img.Width, img.Height) / (double)maxEdge;
            var w = ratio > 1 ? (int)Math.Round(img.Width / ratio) : img.Width;
            var h = ratio > 1 ? (int)Math.Round(img.Height / ratio) : img.Height;

            var bmp = new Bitmap(w, h);
            using var g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.Clear(Color.Transparent);
            g.DrawImage(img, new Rectangle(0, 0, w, h));
            thumb = bmp;
            return true;
        }
    }


}
}
