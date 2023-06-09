using AutoMapper;
using CRUD.API.ViewModels;
using CRUD.Domain.Entities;
using CRUD.Services.DTO;

namespace CRUD.API.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Aluno, AlunoDTO>().ReverseMap();
            CreateMap<AlunoViewModel, AlunoDTO>().ReverseMap();
        }
    }
}
