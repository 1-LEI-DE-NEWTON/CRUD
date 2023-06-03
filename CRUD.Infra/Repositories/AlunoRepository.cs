using CRUD.Domain.Entities;
using CRUD.Infra.Context;
using CRUD.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infra.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public readonly DataContext _context;
        public AlunoRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Aluno> GetByMatricula(string matricula)
        {
            var obj = await _context.Alunos
                .Where(x => x.Matricula == matricula)
                .AsNoTracking()
                .ToListAsync();

            return obj.FirstOrDefault();
        }

        public async Task<Aluno> GetByEmail(string email)
        {
            var obj = await _context.Alunos
                .Where(x => x.Email == email)
                .AsNoTracking()
                .ToListAsync();

            return obj.FirstOrDefault();
        }

        public async Task<Aluno> GetByTelefone(string telefone)
        {
            var obj = await _context.Alunos
                .Where(x => x.Telefone == telefone)
                .AsNoTracking()
                .ToListAsync();

            return obj.FirstOrDefault();
        }

        public async Task<List<Aluno>> SearchByCurso(string curso)
        {
            var obj = await _context.Alunos
                .Where(x => x.Curso.ToLower().Contains(curso.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return obj;
        }

        public async Task<List<Aluno>> SearchByName(string nome)
        {
            var obj = await _context.Alunos
                .Where(x => x.Nome.ToLower().Contains(nome.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return obj;
        }
    }
}
