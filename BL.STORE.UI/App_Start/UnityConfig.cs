using BL.Store.Data.EF.Repositories;
using BL.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BL.STORE.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
         
            container.RegisterType< IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, TipoDeProdutoRepositoryEF>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}