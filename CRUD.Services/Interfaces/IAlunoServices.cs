using CRUD.Domain.Entities;
using CRUD.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Services.Interfaces
{
    public interface IAlunoServices
    {
        Task<AlunoDTO> Create(AlunoDTO aluno);
        Task Remove(long id);
        Task<AlunoDTO> Update(AlunoDTO aluno);
        Task<AlunoDTO> Get(long id);
        Task<AlunoDTO> GetByMatricula(string matricula);
    }
}
