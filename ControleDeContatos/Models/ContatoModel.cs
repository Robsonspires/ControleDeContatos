using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeContatos.Models
{
    [Table("Contatos")]
    public class ContatoModel
    {
        [Column("Id")]
        [Display(Name = "Código")] 
        public int Id { get; set; }
        
        [Column("Nome")]
        [Display(Name = "Nome")] 
        public string? Nome { get; set; }

        [Column("Email")]
        [Display(Name = "e-Mail")]
        public string? Email { get; set;}

        [Column("Celular")]
        [Display(Name = "Celular")]
        public string? Celular { get; set;}

    }
}
