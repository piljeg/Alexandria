using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        protected AppDbContext _appDbContext { get; set; }

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public TEntity Add(TEntity entity)
        {
            return _appDbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Remove(entity);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> match)
        {
            return _appDbContext.Set<TEntity>().SingleOrDefault(match);
        }

        public List<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>().ToList() as List<TEntity>;
        }

        public TEntity GetById(int id)
        {
            return _appDbContext.Set<TEntity>().Find(id);
        }

        public TEntity Update(TEntity updated, int key)
        {
            if (updated == null)
                return null;

            TEntity existing = _appDbContext.Set<TEntity>().Find(key);
            if (existing != null)
            {
                _appDbContext.Entry(existing).CurrentValues.SetValues(updated);
                _appDbContext.SaveChanges();
            }
            return existing;
        }
    }
}

