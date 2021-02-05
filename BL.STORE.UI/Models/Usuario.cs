using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BL.STORE.UI.Models
{
    [Table(nameof(Usuario))]
    public class Usuario: EntIty
    {
        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(80)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(150)]
        public string Senha { get; set; }
    }
}
