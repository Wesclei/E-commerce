using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BL.STORE.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "{0} obrigatório.")]
        [StringLength(40, ErrorMessage = "O limite do {0} é de {1} caracteres.")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "E-mail inválido !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatória.")]
        [StringLength(40, ErrorMessage = "O limite da {0} é de {1} caracteres.")]
        public string Senha { get; set; }

        public bool PermanecerLogado { get; set; }
        public string ReturnUrl { get; set; }
    }
}
