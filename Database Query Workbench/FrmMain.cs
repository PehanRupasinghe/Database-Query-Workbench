using DatabaseQueryWorkbench.Features.EBBSFilesUpload;

namespace DatabaseQueryWorkbench
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmOdbcQueryRunner();
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
