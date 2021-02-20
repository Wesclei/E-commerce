using BL.Store.Domain.Contracts.Repositories;
using BL.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BL.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(BLStoreDataContextEF ctx) : base(ctx) { }

        public IEnumerable<Produto> GetByNameContrains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
