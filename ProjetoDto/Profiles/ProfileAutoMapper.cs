using AutoMapper;
using ProjetoDto.Dto;
using ProjetoDto.Models;

namespace ProjetoDto.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<UsuarioCriacaoDto, UsuarioModel>();
            CreateMap<UsuarioModel, UsuarioListagemDto>();

        }
    }
}
