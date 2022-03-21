using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Save();
    }
}
