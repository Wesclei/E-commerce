using BL.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF<T> : IDisposable, IProdutoRepositoryEF<T> where T : EntIty
    {
        private readonly BLStoreDataContext _ctx = new BLStoreDataContext();

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
            Save();
        }

        public void Edit(T entity)
        {
            _ctx.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            Save();
        }

        private void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
