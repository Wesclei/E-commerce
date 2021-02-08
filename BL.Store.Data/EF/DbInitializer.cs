using BL.Store.Domain.Entities;
using BL.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;


namespace BL.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<BLStoreDataContext>
    {
        protected override void Seed(BLStoreDataContext context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var eletronico = new TipoDeProduto() { Nome = "Eletrônico" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };

            var produtos = new List<Produto>() {
                new Produto(){ Nome = "Desinfetante", Preco = 16.32M,  Qtde = 35,   TipoDeProduto = limpeza},
                new Produto(){ Nome = "Picanaha",     Preco = 70.5M,   Qtde = 17,   TipoDeProduto = alimento},
                new Produto(){ Nome = "Creme Dental", Preco = 2.09M,   Qtde = 13,   TipoDeProduto = higiene},
                new Produto(){ Nome = "Teclado gamer",Preco = 168.53M, Qtde = 16,   TipoDeProduto = eletronico},
                new Produto(){ Nome = "Mouse gamer",  Preco = 72.34M,  Qtde = 29,   TipoDeProduto = eletronico},
                new Produto(){ Nome = "Sabonete",     Preco = 2.96M,   Qtde = 42,   TipoDeProduto = higiene},
                new Produto(){ Nome = "Shampoo",      Preco = 5.44M,   Qtde = 14,   TipoDeProduto = higiene},
            };

            context.Produtos.AddRange(produtos);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Billy",
                Email = "billy@gmail.com",
                Senha = "123456".Encrypt()
            });


            context.SaveChanges();
        }
    }
}
