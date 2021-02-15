using BL.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BL.Store.Data.EF.Repositories
{
    public interface IProdutoRepositoryEF<T> : IDisposable where T : EntIty
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);    
       
    }
}


//https://www.youtube.com/watch?v=ic1aWrgYpC0&list=PLzKclr7RPbI1x48XgRBBbgAlM8eGaf5Qn&index=9
//23:29