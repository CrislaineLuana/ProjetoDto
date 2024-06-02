using ProjetoDto.Models;

namespace ProjetoDto.Services.Usuario
{
    public interface IUsuarioInterface
    {

        List<UsuarioModel> CriarUsuario(UsuarioModel usuarioModel);
        List<UsuarioModel> ListarUsuarios();
    }
}
