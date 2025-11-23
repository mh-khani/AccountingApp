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
    public partial class AddEditCustomer : Form
    {
        public int CustomerID = 0;
        public Customer _Customer;

        UnitOfWork db = new UnitOfWork();
        public AddEditCustomer()
        {
            InitializeComponent();
        }

        private void AddEditCustomer_Load(object sender, EventArgs e)
        {
            if (CustomerID != 0)
            {
                using(UnitOfWork ut = new UnitOfWork())
                {
                    _Customer = ut.CustomerRepository.GetCustomerByID(CustomerID);

                }

                this.Text = "Edit Customer";
                submir.Text = "Edit";

                txt_Address.Text = _Customer.Address;
                txt_Email.Text = _Customer.Email;
                txt_Mobile.Text = _Customer.Mobile;
                txt_Name.Text = _Customer.FullName;
                if (_Customer.Image != null && File.Exists(Application.StartupPath + "/Images/Customers/" + _Customer.Image))
                    Customerimage.ImageLocation = Application.StartupPath + "/Images/Customers/" + _Customer.Image;
            }
        }

        private void submir_Click(object sender, EventArgs e)
        {
            if (ValidateMembers())
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(Customerimage.ImageLocation);
                string path = Application.StartupPath + "/Images/Customers/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Customerimage.Image.Save(path + ImageName);

                Customer customer = new Customer()
                {
                    FullName = txt_Name.Text,
                    Mobile = txt_Mobile.Text,
                    Email = txt_Email.Text,
                    Address = txt_Address.Text,
                    Image = ImageName
                };

                if (CustomerID == 0)
                    db.CustomerRepository.InsertCustomer(customer);
                else
                {
                    customer.CustomerId = CustomerID;
                    db.CustomerRepository.UpdateCustomer(customer);
                }

                db.Save();
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("Please Fill All Requier Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Customerimage.ImageLocation = dialog.FileName;
            }
        }
        private bool ValidateMembers()
        {
            bool state = true;

            if (string.IsNullOrEmpty(txt_Name.Text))
                state = false;
            if (string.IsNullOrEmpty(txt_Mobile.Text))
                state = false;
            if (Customerimage.ImageLocation == null)
                state = false;

            return state;
        }
    }
}
