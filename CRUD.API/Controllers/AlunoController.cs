using CRUD.Domain.Entities;
using CRUD.Infra.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class AlunoController : ControllerBase
        {
            private readonly DataContext _context;

        public AlunoController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
            public async Task<ActionResult<Aluno>> CreateAluno(Aluno aluno)
            {
                _context.Alunos.Add(aluno);
                await _context.SaveChangesAsync();
                return Ok(await _context.Alunos.ToListAsync());
            }
        }
}
