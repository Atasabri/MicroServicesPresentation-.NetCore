using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExamsService_Domain.IRepositories
{
   public interface IGeneralRepository<TEntity> where TEntity : class
    {
        void CreateOrUpdate(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> AllData();
        IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> func);
        TEntity FindElement(Expression<Func<TEntity, bool>> func);
        TEntity Find(int ID);
    }
}
