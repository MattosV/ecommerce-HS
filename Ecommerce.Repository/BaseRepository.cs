using System;
using System.Linq;
using System.Data.Entity;
using Ecommerce.Repository.Interfaces;

namespace Ecommerce.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        protected DbContext Context;

        public BaseRepository(DbContext dbContext)
        {
            Context = dbContext;
        } 

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> Get(Func<T, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public T Find(params object[] key)
        {
            return Context.Set<T>().Find(key);
        }

        public void Update(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Add(T obj)
        {
            Context.Set<T>().Add(obj);
        }

        public void Delete(Func<T, bool> predicate)
        {
            Context.Set<T>()
                .Where(predicate).ToList()
                .ForEach(del => Context.Set<T>().Remove(del));
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Delete(T entity)
        {
            Context.Database.Log = Console.Write;

            Context.Set<T>().Remove(entity);
        }
    }
}