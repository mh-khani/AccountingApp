using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using Utility;

namespace AccountingApp
{
    public partial class frmReport : Form
    {
        public int TypeId = 1;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
       


            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();

            customerViewModels.Add(new CustomerViewModel() { CustomerName = "Select", CustomerID = 0 });

            using (UnitOfWork db = new UnitOfWork())
            {
                customerViewModels.AddRange(db.CustomerRepository.GetAllCustomerViewModel());
            }

            cmContact.DataSource = customerViewModels;
            cmContact.DisplayMember = "CustomerName";
            cmContact.ValueMember = "CustomerID";

            if (TypeId == 1)
                this.Text = "Income Report";
            else
                Text = "Expense Report";

            Filter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting> res = new List<Accounting>();
                DateTime? startDate;
                DateTime? endDate;

                if ((int)cmContact.SelectedValue == 0)
                    res = db.AccountingRepository.GetWithRelations(a => a.TypeId == TypeId).ToList();
                else
                    res = db.AccountingRepository.GetWithRelations(a => a.TypeId == TypeId &&
                    a.CustomerId == (int)cmContact.SelectedValue).ToList();

                if (textFrom.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(textFrom.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    res = res.Where(a => a.DateTime >= startDate.Value).ToList();
                }
                if (txtTo.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtTo.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    res = res.Where(a => a.DateTime <= endDate.Value).ToList();
                }
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = res;
            }
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                    var accounting = db.AccountingRepository.GetById(id);
                    if (accounting != null)
                    {
                        db.AccountingRepository.Delete(accounting);
                        db.Save();
                        Filter();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                NewTransaction frm = new NewTransaction();
                frm.AccountID = id;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }

            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


    }
}
