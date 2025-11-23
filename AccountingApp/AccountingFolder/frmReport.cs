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
    }
}
