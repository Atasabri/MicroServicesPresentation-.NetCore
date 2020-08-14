using ExamsService_Domain.DBContext;
using ExamsService_Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExamsService_Business.Repositories
{
    public class GeneralRepository<TEntity> : IGeneralRepository<TEntity> where TEntity : class
    {
        protected DBExams db;

        public GeneralRepository(DBExams _db)
        {
            this.db = _db;
        }

        public IEnumerable<TEntity> AllData()
        {
            return db.Set<TEntity>().ToList();
        }

        public void CreateOrUpdate(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public TEntity Find(int ID)
        {
            return db.Set<TEntity>().Find(ID);
        }

        public TEntity FindElement(Expression<Func<TEntity, bool>> func)
        {
            return db.Set<TEntity>().FirstOrDefault(func);
        }

        public IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> func)
        {
            return db.Set<TEntity>().Where(func);
        }
    }
}
