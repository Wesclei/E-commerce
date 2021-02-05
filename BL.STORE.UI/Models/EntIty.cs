using System;
using System.ComponentModel.DataAnnotations;

namespace BL.STORE.UI.Models
{
    public class EntIty
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;


    }
}
