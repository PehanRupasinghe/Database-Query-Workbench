
namespace DatabaseQueryWorkbench.Features.EBBSFilesUpload
{
    partial class FrmOdbcQueryRunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdbcQueryRunner));
            grpV1ExecutionLog = new GroupBox();
            pBLoadingODBCSQLQuery = new PictureBox();
            richTextODBCSQLQuery = new RichTextBox();
            groupBox1 = new GroupBox();
            pBLoadingExecutionLog = new PictureBox();
            txtExecutionLog = new RichTextBox();
            gbV1P2RecordList = new GroupBox();
            pBLoadingRecordList = new PictureBox();
            lblV1P2Records = new Label();
            dgvV1P2RecordList = new DataGridView();
            btnV1Execute = new Button();
            btnV1ClearLog = new Button();
            btnV1Cancel = new Button();
            txtConnectionString = new TextBox();
            label1 = new Label();
            txtTimeoutSec = new NumericUpDown();
            label2 = new Label();
            grpV1ExecutionLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLoadingODBCSQLQuery).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLoadingExecutionLog).BeginInit();
            gbV1P2RecordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLoadingRecordList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvV1P2RecordList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTimeoutSec).BeginInit();
            SuspendLayout();
            // 
            // grpV1ExecutionLog
            // 
            grpV1ExecutionLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpV1ExecutionLog.BackColor = Color.Transparent;
            grpV1ExecutionLog.Controls.Add(pBLoadingODBCSQLQuery);
            grpV1ExecutionLog.Controls.Add(richTextODBCSQLQuery);
            grpV1ExecutionLog.FlatStyle = FlatStyle.Flat;
            grpV1ExecutionLog.ForeColor = Color.Black;
            grpV1ExecutionLog.Location = new Point(12, 39);
            grpV1ExecutionLog.Margin = new Padding(3, 2, 3, 2);
            grpV1ExecutionLog.Name = "grpV1ExecutionLog";
            grpV1ExecutionLog.Padding = new Padding(3, 2, 3, 2);
            grpV1ExecutionLog.Size = new Size(490, 396);
            grpV1ExecutionLog.TabIndex = 702;
            grpV1ExecutionLog.TabStop = false;
            grpV1ExecutionLog.Text = "ODBC SQL query";
            // 
            // pBLoadingODBCSQLQuery
            // 
            pBLoadingODBCSQLQuery.BackColor = Color.FromArgb(34, 45, 50);
            pBLoadingODBCSQLQuery.BackgroundImageLayout = ImageLayout.Center;
            pBLoadingODBCSQLQuery.Dock = DockStyle.Fill;
            pBLoadingODBCSQLQuery.Image = Properties.Resources.Bounce_Bar_Preloader_48x48;
            pBLoadingODBCSQLQuery.Location = new Point(3, 17);
            pBLoadingODBCSQLQuery.Name = "pBLoadingODBCSQLQuery";
            pBLoadingODBCSQLQuery.Size = new Size(484, 377);
            pBLoadingODBCSQLQuery.SizeMode = PictureBoxSizeMode.CenterImage;
            pBLoadingODBCSQLQuery.TabIndex = 719;
            pBLoadingODBCSQLQuery.TabStop = false;
            // 
            // richTextODBCSQLQuery
            // 
            richTextODBCSQLQuery.Dock = DockStyle.Fill;
            richTextODBCSQLQuery.Location = new Point(3, 17);
            richTextODBCSQLQuery.Name = "richTextODBCSQLQuery";
            richTextODBCSQLQuery.Size = new Size(484, 377);
            richTextODBCSQLQuery.TabIndex = 1;
            richTextODBCSQLQuery.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pBLoadingExecutionLog);
            groupBox1.Controls.Add(txtExecutionLog);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(505, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(507, 398);
            groupBox1.TabIndex = 703;
            groupBox1.TabStop = false;
            groupBox1.Text = "Execution Log";
            // 
            // pBLoadingExecutionLog
            // 
            pBLoadingExecutionLog.BackColor = Color.FromArgb(34, 45, 50);
            pBLoadingExecutionLog.BackgroundImageLayout = ImageLayout.Center;
            pBLoadingExecutionLog.Dock = DockStyle.Fill;
            pBLoadingExecutionLog.Image = Properties.Resources.Bounce_Bar_Preloader_48x48;
            pBLoadingExecutionLog.Location = new Point(3, 17);
            pBLoadingExecutionLog.Name = "pBLoadingExecutionLog";
            pBLoadingExecutionLog.Size = new Size(501, 379);
            pBLoadingExecutionLog.SizeMode = PictureBoxSizeMode.CenterImage;
            pBLoadingExecutionLog.TabIndex = 719;
            pBLoadingExecutionLog.TabStop = false;
            // 
            // txtExecutionLog
            // 
            txtExecutionLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtExecutionLog.BackColor = Color.FromArgb(34, 45, 50);
            txtExecutionLog.BorderStyle = BorderStyle.None;
            txtExecutionLog.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExecutionLog.ForeColor = Color.White;
            txtExecutionLog.Location = new Point(7, 17);
            txtExecutionLog.MaxLength = 35;
            txtExecutionLog.Name = "txtExecutionLog";
            txtExecutionLog.ReadOnly = true;
            txtExecutionLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtExecutionLog.Size = new Size(493, 373);
            txtExecutionLog.TabIndex = 307;
            txtExecutionLog.Text = "";
            // 
            // gbV1P2RecordList
            // 
            gbV1P2RecordList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbV1P2RecordList.BackColor = Color.Transparent;
            gbV1P2RecordList.Controls.Add(pBLoadingRecordList);
            gbV1P2RecordList.Controls.Add(lblV1P2Records);
            gbV1P2RecordList.Controls.Add(dgvV1P2RecordList);
            gbV1P2RecordList.FlatStyle = FlatStyle.Flat;
            gbV1P2RecordList.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbV1P2RecordList.ForeColor = Color.Black;
            gbV1P2RecordList.Location = new Point(12, 442);
            gbV1P2RecordList.Name = "gbV1P2RecordList";
            gbV1P2RecordList.Size = new Size(1000, 271);
            gbV1P2RecordList.TabIndex = 709;
            gbV1P2RecordList.TabStop = false;
            gbV1P2RecordList.Text = "Record List";
            // 
            // pBLoadingRecordList
            // 
            pBLoadingRecordList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBLoadingRecordList.BackColor = Color.FromArgb(45, 66, 91);
            pBLoadingRecordList.BackgroundImageLayout = ImageLayout.Center;
            pBLoadingRecordList.Image = Properties.Resources.Bounce_Bar_Preloader_48x48;
            pBLoadingRecordList.Location = new Point(446, 111);
            pBLoadingRecordList.Name = "pBLoadingRecordList";
            pBLoadingRecordList.Size = new Size(97, 59);
            pBLoadingRecordList.SizeMode = PictureBoxSizeMode.CenterImage;
            pBLoadingRecordList.TabIndex = 737;
            pBLoadingRecordList.TabStop = false;
            // 
            // lblV1P2Records
            // 
            lblV1P2Records.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblV1P2Records.BackColor = Color.Transparent;
            lblV1P2Records.Location = new Point(819, 13);
            lblV1P2Records.Name = "lblV1P2Records";
            lblV1P2Records.Size = new Size(175, 22);
            lblV1P2Records.TabIndex = 727;
            lblV1P2Records.Text = "0 : &Records";
            lblV1P2Records.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvV1P2RecordList
            // 
            dgvV1P2RecordList.AllowUserToOrderColumns = true;
            dgvV1P2RecordList.AllowUserToResizeColumns = false;
            dgvV1P2RecordList.AllowUserToResizeRows = false;
            dgvV1P2RecordList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvV1P2RecordList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvV1P2RecordList.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvV1P2RecordList.BorderStyle = BorderStyle.None;
            dgvV1P2RecordList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 232, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(31, 118, 189);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvV1P2RecordList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvV1P2RecordList.ColumnHeadersHeight = 28;
            dgvV1P2RecordList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 118, 189);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvV1P2RecordList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvV1P2RecordList.EnableHeadersVisualStyles = false;
            dgvV1P2RecordList.GridColor = Color.WhiteSmoke;
            dgvV1P2RecordList.Location = new Point(7, 38);
            dgvV1P2RecordList.Name = "dgvV1P2RecordList";
            dgvV1P2RecordList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(223, 232, 240);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 118, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvV1P2RecordList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvV1P2RecordList.RowHeadersWidth = 25;
            dgvV1P2RecordList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvV1P2RecordList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvV1P2RecordList.Size = new Size(987, 227);
            dgvV1P2RecordList.TabIndex = 309;
            dgvV1P2RecordList.TabStop = false;
            // 
            // btnV1Execute
            // 
            btnV1Execute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnV1Execute.BackColor = Color.FromArgb(31, 118, 189);
            btnV1Execute.Cursor = Cursors.Hand;
            btnV1Execute.FlatAppearance.BorderSize = 0;
            btnV1Execute.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 66, 91);
            btnV1Execute.FlatStyle = FlatStyle.Flat;
            btnV1Execute.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnV1Execute.ForeColor = Color.White;
            btnV1Execute.Location = new Point(700, 13);
            btnV1Execute.Margin = new Padding(3, 5, 3, 5);
            btnV1Execute.Name = "btnV1Execute";
            btnV1Execute.Size = new Size(100, 25);
            btnV1Execute.TabIndex = 738;
            btnV1Execute.Text = "&Execute (F5)";
            btnV1Execute.UseVisualStyleBackColor = false;
            btnV1Execute.Click += btnV1Execute_Click;
            // 
            // btnV1ClearLog
            // 
            btnV1ClearLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnV1ClearLog.BackColor = Color.FromArgb(31, 118, 189);
            btnV1ClearLog.Cursor = Cursors.Hand;
            btnV1ClearLog.FlatAppearance.BorderSize = 0;
            btnV1ClearLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 66, 91);
            btnV1ClearLog.FlatStyle = FlatStyle.Flat;
            btnV1ClearLog.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnV1ClearLog.ForeColor = Color.White;
            btnV1ClearLog.Location = new Point(912, 13);
            btnV1ClearLog.Margin = new Padding(3, 5, 3, 5);
            btnV1ClearLog.Name = "btnV1ClearLog";
            btnV1ClearLog.Size = new Size(100, 25);
            btnV1ClearLog.TabIndex = 736;
            btnV1ClearLog.Text = "&Clear Log";
            btnV1ClearLog.UseVisualStyleBackColor = false;
            btnV1ClearLog.Click += btnV1ClearLog_Click;
            // 
            // btnV1Cancel
            // 
            btnV1Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnV1Cancel.BackColor = Color.FromArgb(31, 118, 189);
            btnV1Cancel.Cursor = Cursors.Hand;
            btnV1Cancel.FlatAppearance.BorderSize = 0;
            btnV1Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 66, 91);
            btnV1Cancel.FlatStyle = FlatStyle.Flat;
            btnV1Cancel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnV1Cancel.ForeColor = Color.White;
            btnV1Cancel.Location = new Point(806, 13);
            btnV1Cancel.Margin = new Padding(3, 5, 3, 5);
            btnV1Cancel.Name = "btnV1Cancel";
            btnV1Cancel.Size = new Size(100, 25);
            btnV1Cancel.TabIndex = 735;
            btnV1Cancel.Text = "&Cancel";
            btnV1Cancel.UseVisualStyleBackColor = false;
            btnV1Cancel.Click += btnV1Cancel_Click;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConnectionString.Location = new Point(186, 12);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(285, 22);
            txtConnectionString.TabIndex = 739;
            txtConnectionString.Text = "Driver={iSeries Access ODBC Driver};System=pub400.com;Uid=PEHANR;Pwd=#Dms0727;";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(165, 13);
            label1.TabIndex = 740;
            label1.Text = "Enter ODBC connection string:";
            // 
            // txtTimeoutSec
            // 
            txtTimeoutSec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimeoutSec.Location = new Point(615, 13);
            txtTimeoutSec.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtTimeoutSec.Name = "txtTimeoutSec";
            txtTimeoutSec.Size = new Size(72, 22);
            txtTimeoutSec.TabIndex = 741;
            txtTimeoutSec.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(477, 15);
            label2.Name = "label2";
            label2.Size = new Size(132, 13);
            label2.TabIndex = 742;
            label2.Text = "Command Timeout Sec : ";
            // 
            // FrmOdbcQueryRunner
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 725);
            Controls.Add(label2);
            Controls.Add(txtTimeoutSec);
            Controls.Add(label1);
            Controls.Add(txtConnectionString);
            Controls.Add(btnV1Execute);
            Controls.Add(gbV1P2RecordList);
            Controls.Add(btnV1ClearLog);
            Controls.Add(btnV1Cancel);
            Controls.Add(groupBox1);
            Controls.Add(grpV1ExecutionLog);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmOdbcQueryRunner";
            Text = "Database Query Workbench";
            Load += FrmOdbcQueryRunner_Load;
            grpV1ExecutionLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLoadingODBCSQLQuery).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLoadingExecutionLog).EndInit();
            gbV1P2RecordList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLoadingRecordList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvV1P2RecordList).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTimeoutSec).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpV1ExecutionLog;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pBLoadingExecutionLog;
        private System.Windows.Forms.RichTextBox txtExecutionLog;
        private System.Windows.Forms.GroupBox gbV1P2RecordList;
        private System.Windows.Forms.Label lblV1P2Records;
        private System.Windows.Forms.DataGridView dgvV1P2RecordList;
        private System.Windows.Forms.Button btnV1ClearLog;
        private System.Windows.Forms.Button btnV1Cancel;
        public System.Windows.Forms.PictureBox pBLoadingRecordList;
        private System.Windows.Forms.Button btnV1Execute;
        private RichTextBox richTextODBCSQLQuery;
        public PictureBox pBLoadingODBCSQLQuery;
        private TextBox txtConnectionString;
        private Label label1;
        private NumericUpDown txtTimeoutSec;
        private Label label2;
    }
}