using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Serives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        AccountingDbContext db = new AccountingDbContext();

        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        private GenericRepository<Accounting> _accountingRepositoey;

        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepositoey == null)
                    _accountingRepositoey = new GenericRepository<Accounting>(db);
                 
                return _accountingRepositoey;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
