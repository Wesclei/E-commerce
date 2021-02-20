using BL.Store.Domain.Contracts.Repositories;
using BL.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BL.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(BLStoreDataContextEF ctx) : base(ctx) { }

        public Usuario Get(string email)
        {

            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }

        void IRepository<TipoDeProduto>.Add(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<TipoDeProduto>.Delete(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<TipoDeProduto>.Edit(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<TipoDeProduto> IRepository<TipoDeProduto>.Get()
        {
            throw new System.NotImplementedException();
        }

        TipoDeProduto IRepository<TipoDeProduto>.Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
