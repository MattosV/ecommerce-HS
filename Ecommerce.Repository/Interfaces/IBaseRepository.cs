using System;
using System.Linq;

namespace Ecommerce.Repository.Interfaces
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Func<T, bool> predicate);
        T Find(params object[] key);
        void Update(T obj);
        void SaveChanges();
        void Add(T obj);
        void Delete(Func<T, bool> predicate);
        void Delete(T entity);
    }
}