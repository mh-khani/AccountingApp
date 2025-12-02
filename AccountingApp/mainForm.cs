using Utility;

namespace AccountingApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            Form form = new frmCustomer();
            form.ShowDialog();
        }

        private void addTransaction_Click(object sender, EventArgs e)
        {
            Form form = new NewTransaction();
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var form = new frmReport();
            form.TypeId = 1;
            form.ShowDialog();
        }

        private void btnreport2_Click(object sender, EventArgs e)
        {
            var form = new frmReport();
            form.TypeId = 2;
            form.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShamsi().ToString();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("HH:mm:ss");


            this.Hide();
            Form form = new LoginForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void loginSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.isEdit = true;
            form.ShowDialog();
        }
    }
}
