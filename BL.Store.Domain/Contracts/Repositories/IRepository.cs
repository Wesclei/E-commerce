using BL.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BL.Store.Domain.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T : EntIty
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);

    }
   
}
