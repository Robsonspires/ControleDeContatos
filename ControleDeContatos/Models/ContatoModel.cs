using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeContatos.Models
{
    [Table("Contatos")]
    public class ContatoModel
    {

        public int Id { get; set; }
        
        [Required(ErrorMessage ="Digite o nome do contato.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato.")]
        [EmailAddress(ErrorMessage ="O e-mail informado não é válido.")]
        public string? Email { get; set;}

        [Required(ErrorMessage = "Digite o celular do contato.")]
        [Phone(ErrorMessage ="O Celular informado não é válido.")]
        public string? Celular { get; set;}

    }
}
