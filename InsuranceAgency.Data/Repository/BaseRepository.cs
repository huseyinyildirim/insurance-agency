using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity, new()
    {
        protected AppDbContext _context { get; set; }

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
