using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.Infra.Interfaces;
using CRUD.Services.DTO;
using CRUD.Services.Interfaces;
using System.Dynamic;

namespace CRUD.Services.Services
{
    public class AlunoServices : IAlunoServices
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public AlunoServices(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<AlunoDTO> Create(AlunoDTO alunoDTO)
        {
            var aluno = _mapper.Map<Aluno>(alunoDTO);
            var alunoCreated = await _alunoRepository.Create(aluno);
            return _mapper.Map<AlunoDTO>(alunoCreated);
        }

        public async Task<AlunoDTO> Update (AlunoDTO alunoDTO)
        {
            var alunoEntity = _mapper.Map<Aluno>(alunoDTO);
            var alunoUpdated = await _alunoRepository.Update(alunoEntity);
            return _mapper.Map<AlunoDTO>(alunoUpdated);
        }

        public async Task Remove (long id)
        {
            await _alunoRepository.Remove(id);
        }

        public async Task<AlunoDTO> Get(long id)
        {
            var aluno = await _alunoRepository.Get(id);
            return _mapper.Map<AlunoDTO>(aluno);
        }

        public async Task<AlunoDTO> GetByMatricula(string matricula)
        {
            var aluno = await _alunoRepository.GetByMatricula(matricula);
            return _mapper.Map<AlunoDTO>(aluno);
        }
    }
}
