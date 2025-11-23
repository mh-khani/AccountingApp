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
    public class GenericRepository<TEntity> where TEntity : class
    {
        private AccountingDbContext _dbContext;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(AccountingDbContext DbContext)
        {
            _dbContext = DbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
                query = query.Where(where);

            return query.ToList();
        }
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if(_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object id)
        {
            var Entity = GetById(id);
            Delete(Entity);
        }
    }
}
