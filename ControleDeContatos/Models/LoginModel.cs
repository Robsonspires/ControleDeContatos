using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login.")]
        public String? Login { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public String? Senha { get; set; }
    }
}
