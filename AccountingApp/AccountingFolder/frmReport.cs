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
                var res = db.AccountingRepository.GetWithRelations(a => a.TypeId == TypeId);

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = res.ToList();
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

                if(frm.ShowDialog() == DialogResult.OK)
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
