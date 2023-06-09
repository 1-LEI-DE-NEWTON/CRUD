using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Services.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        public AlunoDTO() { }

        public AlunoDTO(string nome, string email, DateTime dataNascimento, string telefone, string matricula, string curso)
            : base (nome, email, dataNascimento, telefone)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
