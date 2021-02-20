using System;

namespace BL.Store.Domain.Entities
{
    public class EntIty    {
        public EntIty()
        {
            DataCadastro = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } 

    }
}
