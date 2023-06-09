using System.ComponentModel.DataAnnotations;

namespace CRUD.API.ViewModels
{
    public class AlunoViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public System.DateTime DataNascimento { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Matricula { get; set; }
        [Required]
        public string Curso { get; set; }        
    }
}
