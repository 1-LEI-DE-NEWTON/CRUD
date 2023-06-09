using AutoMapper;
using CRUD.API.ViewModels;
using CRUD.Services.DTO;
using CRUD.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAlunoServices _alunoService;

        public AlunoController(IMapper mapper, IAlunoServices alunoService)
        {
            _mapper = mapper;
            _alunoService = alunoService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AlunoViewModel alunoViewModel)
        {
            var alunoDTO = _mapper.Map<AlunoDTO>(alunoViewModel);
            var alunoCreated = await _alunoService.Create(alunoDTO);            
            return Ok(alunoCreated);
        }
    }
}