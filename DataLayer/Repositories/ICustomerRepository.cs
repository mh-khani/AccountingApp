using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomer();
        List<CustomerViewModel> GetAllCustomerViewModel(string search = "");
        IEnumerable<Customer> GetCustomersByFolter(string search);
        Customer GetCustomerByID(int customerID);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int customerID);
        bool DeleteCustomer(Customer customer);
        int GetCustomerIdByName(string name);
    }
}
