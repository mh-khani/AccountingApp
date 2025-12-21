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
                query = query.Where(where);

            return query.Include(a => a.Customer).ToList();
        }
        public virtual Accounting GetByIdwihtRelations(object id)
        {
            return _dbSet.Include(a => a.Customer).FirstOrDefault(a => a.Id == (int)id);
        }
    }
}
