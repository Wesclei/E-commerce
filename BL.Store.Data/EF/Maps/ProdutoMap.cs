using BL.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BL.Store.Data.EF.Maps
{
    public class ProdutoMap : EntityTypeConfiguration <Produto>
    {
        public ProdutoMap()
        {
            //Tabela
            ToTable(nameof(Produto));
            //PK
            HasKey(PK => PK.Id);
            //Colunas
            Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(120).IsRequired();
            Property(c => c.Preco).HasColumnType("money");
            Property(c => c.Qtde).HasParameterName("Quantidade");
            Property(c => c.TipoDeProdutoId);
            Property(c => c.DataCadastro);
            //Relacionamento 1 tipo de produto esta relacionado a 1 tipo de produto, e 1 tipo de produto esta relacionado a N produtos
            HasRequired(prod => prod.TipoDeProduto).WithMany(tipo => tipo.Produtos).HasForeignKey(fk => fk.TipoDeProdutoId);
        }
    }
}
