using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public abstract class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }        

        public Pessoa() { }

        public Pessoa(string nome, string email, DateTime dataNascimento, string telefone)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;
        }

        //Comportamentos

        public void changeEmail(string email)
        {
            Email = email;
        }

        public void changeTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}