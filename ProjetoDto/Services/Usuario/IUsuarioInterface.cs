using ProjetoDto.Dto;
using ProjetoDto.Models;

namespace ProjetoDto.Services.Usuario
{
    public interface IUsuarioInterface
    {

        List<UsuarioListagemDto> CriarUsuario(UsuarioCriacaoDto usuarioModel);

    }
}
