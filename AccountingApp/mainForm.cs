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
    }
}
