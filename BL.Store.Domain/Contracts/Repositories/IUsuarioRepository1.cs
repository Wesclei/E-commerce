using BL.Store.Domain.Entities;

namespace BL.Store.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository1
    {
        Usuario Get(string email);
    }
}