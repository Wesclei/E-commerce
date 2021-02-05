using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BL.STORE.UI.Models
{
    [Table(nameof(TipoDeProduto))]
    public class TipoDeProduto:EntIty
    {

        [Required, Column(TypeName = "varchar"), StringLength(100)]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
