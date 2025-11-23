using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Serives
{
    public class AccountingRespository : GenericRepository<Accounting>
    {
        public AccountingRespository(AccountingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
