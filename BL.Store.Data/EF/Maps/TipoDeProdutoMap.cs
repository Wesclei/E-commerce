using BL.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BL.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap : EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //Table
            ToTable(nameof(TipoDeProduto));
            //PK
            HasKey(pk => pk.Id);
            //columns
            Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(120).IsRequired();
            Property(c => c.DataCadastro);
        }
    }
}
