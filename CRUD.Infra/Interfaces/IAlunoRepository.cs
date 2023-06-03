using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Interfaces
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        Task<Aluno> GetByMatricula(string matricula);
        Task<Aluno> GetByEmail(string email);
        Task<Aluno> GetByTelefone(string telefone);
        Task<List<Aluno>> SearchByName(string nome);
        Task<List<Aluno>> SearchByCurso(string curso);
    }
}
