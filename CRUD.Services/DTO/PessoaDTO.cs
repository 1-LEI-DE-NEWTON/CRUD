using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Services.DTO
{
    public abstract class PessoaDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }

        public PessoaDTO() { }

        public PessoaDTO(string nome, string email, DateTime dataNascimento, string telefone)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;
        }
    }    
}
