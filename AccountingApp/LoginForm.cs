using DataLayer.Context;
using Microsoft.IdentityModel.Tokens;
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
    public partial class LoginForm : Form
    {
        public bool isEdit = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.IsNullOrEmpty() && !textBox2.Text.IsNullOrEmpty())
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (isEdit)
                    {
                        var login = db.UserRepository.Get().First();
                        login.Username = textBox1.Text;
                        login.Password = textBox2.Text;
                        db.UserRepository.Update(login);
                        db.Save();

                        Application.Restart();
                    }
                    else
                    {
                        if (db.UserRepository.Get(a => a.Username == textBox1.Text && a.Password == textBox2.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No User Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("PLZ Fill All Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                Text = "Edit User Info";
                button1.Text = "Edit User";

                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.UserRepository.Get().First();
                    textBox1.Text = login.Username;
                    textBox2.Text = login.Password;
                }
            }
        }
    }
}
