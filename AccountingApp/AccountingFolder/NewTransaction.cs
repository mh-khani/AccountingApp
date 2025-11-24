using DataLayer.Context;
using ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;

namespace AccountingApp
{
    public partial class NewTransaction : Form
    {
        public int AccountID = 0;
        Accounting accounting = null;

        UnitOfWork db = new UnitOfWork();
        public NewTransaction()
        {
            InitializeComponent();
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {
            DGVcustomer.RowHeadersVisible = false;
            DGVcustomer.AutoGenerateColumns = false;
            LoadCustomers();

            if (AccountID != 0)
            {
                this.Text = "Edit Transaction";
                button1.Text = "Edit";

                accounting = db.AccountingRepository.GetByIdwihtRelations(AccountID);
                Contacttxt.Text = accounting.Customer.FullName;
                amount.Value = accounting.Amount;
                des.Text = accounting.Description;
                if (accounting.TypeId == 1)
                {
                    income.Checked = true;
                }
                else
                {
                    Payment.Checked = true;
                }

            }
        }

        private void customersearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        void LoadCustomers()
        {
            DGVcustomer.DataSource = db.CustomerRepository.GetAllCustomerViewModel(customersearch.Text);
        }

        private void DGVcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGVcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Contacttxt.Text = DGVcustomer.CurrentRow.Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (income.Checked || Payment.Checked)
            {
                if(AccountID != 0 && accounting != null)
                {
                    accounting.Amount = (int)amount.Value;
                    accounting.CustomerId = db.CustomerRepository.GetCustomerIdByName(Contacttxt.Text);
                    accounting.TypeId = income.Checked ? 1 : 2;
                    accounting.DateTime = DateTime.Now;
                    accounting.Description = des.Text;
                    db.AccountingRepository.Update(accounting);
                    db.Save();
                    DialogResult = DialogResult.OK;
                    return;
                }

                Accounting newaccounting = new Accounting()
                {
                    Amount = (int)amount.Value,
                    CustomerId = db.CustomerRepository.GetCustomerIdByName(Contacttxt.Text),
                    TypeId = income.Checked ? 1 : 2,
                    DateTime = DateTime.Now,
                    Description = des.Text
                };
                db.AccountingRepository.Insert(newaccounting);
                db.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Plz Choose Transaction Type", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
