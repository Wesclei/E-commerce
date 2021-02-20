using BL.Store.Domain.Entities;
using System.Collections.Generic;

namespace BL.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetByNameContrains(string contains);


    }
}
