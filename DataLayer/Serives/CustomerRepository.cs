using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace DataLayer.Serives
{
    public class CustomerRepository : ICustomerRepository
    {
        AccountingDbContext db;

        public CustomerRepository(AccountingDbContext _db)
        {
            db = _db;
        }

        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerByID(int customerID)
        {
            return db.Customers.Find(customerID);
        }
        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Customers.Update(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerID)
        {
            return DeleteCustomer(db.Customers.Find(customerID));
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Customers.Remove(customer);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption " + ex.Message);
                return false;
            }
        }
        public IEnumerable<Customer> GetCustomersByFolter(string search)
        {
            return db.Customers
                .Where(c => c.FullName.Contains(search) || c.Mobile.Contains(search) || c.Email.Contains(search))
                .ToList();
        }

        public List<CustomerViewModel> GetAllCustomerViewModel(string search = "")
        {
            if (search == "")
            {
                return db.Customers
                    .Select(c => new CustomerViewModel
                    {
                        CustomerID = c.CustomerId,
                        CustomerName = c.FullName
                    }).ToList();
            }

            return db.Customers
                .Where(c => c.FullName.Contains(search))
                .Select(c => new CustomerViewModel
                {
                    CustomerID = c.CustomerId,
                    CustomerName = c.FullName
                }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName.Equals(name)).CustomerId;
        }
    }
}
