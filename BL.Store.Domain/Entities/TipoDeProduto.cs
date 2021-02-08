using System.Collections.Generic;

namespace BL.Store.Domain.Entities
{
    public class TipoDeProduto : EntIty
    {
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
