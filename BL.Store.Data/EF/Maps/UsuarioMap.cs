using BL.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BL.Store.Data.EF.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Tabela
            ToTable(nameof(Usuario));
            //PK
            HasKey(PK => PK.Id);
            //Colunas
            Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(120).IsRequired();
            Property(c => c.Email).HasColumnType("varchar").HasMaxLength(80).IsRequired();
            Property(c => c.Senha).HasColumnType("char").HasMaxLength(88).IsRequired();
            Property(c => c.DataCadastro);
        }
    }
}
