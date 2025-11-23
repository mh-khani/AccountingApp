using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Serives
{
    public class AccountingRespository : GenericRepository<Accounting>
    {
        public AccountingRespository(AccountingDbContext dbContext) : base(dbContext)
        {
        }
        public virtual IEnumerable<Accounting> GetWithRelations(Expression<Func<Accounting, bool>> where = null)
        {
            IQueryable<Accounting> query = _dbSet;

            if (where != null)
                query = query.Where(where).Include(a => a.Customer);

            return query.ToList();
        }
    }
}
