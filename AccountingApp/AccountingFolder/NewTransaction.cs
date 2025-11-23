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
                Accounting accounting = new Accounting()
                {
                    Amount = (int)amount.Value,
                    CustomerId = db.CustomerRepository.GetCustomerIdByName(Contacttxt.Text),
                    TypeId = income.Checked ? 1 : 2,
                    DateTime = DateTime.Now,
                    Description = des.Text
                };
                db.AccountingRepository.Insert(accounting);
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
