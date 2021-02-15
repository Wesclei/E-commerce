using BL.Store.Domain.Entities;
using System.Data.Entity;

namespace BL.Store.Data.EF
{
    public class BLStoreDataContext : DbContext
    {
        public BLStoreDataContext() : base(@"StoreConn")
        {
            //Caso a base de dados não exista, crie...
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.ProdutoMap());
            modelBuilder.Configurations.Add(new Maps.TipoDeProdutoMap());
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());
        }
    }
}
