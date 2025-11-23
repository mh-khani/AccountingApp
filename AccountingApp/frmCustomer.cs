using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.CustomerRepository.GetAllCustomer();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBox1.Text))
            {
                Refresh();
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dataGridView1.DataSource = db.CustomerRepository.GetCustomersByFolter(toolStripTextBox1.Text);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show($"Are You Sure to want Delete {dataGridView1.CurrentRow.Cells["FullName"].Value} ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(id);
                        db.Save();
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEditCustomer addEditCustomer = new AddEditCustomer();
            if (addEditCustomer.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    AddEditCustomer addEditCustomer = new AddEditCustomer();
                    addEditCustomer.CustomerID = id;

                    if (addEditCustomer.ShowDialog() == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
