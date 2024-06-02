using ProjetoDto.Models;

namespace ProjetoDto.Services.Usuario
{
    public class UsuarioService : IUsuarioInterface
    {

        List<UsuarioModel> usuarios = new List<UsuarioModel>()
        {
            new UsuarioModel()
            {
                Id = 1,
                Usuario = "CarlosEduardo",
                Nome = "Carlos Eduardo",
                Cargo = "Atendente",
                Senha = "123456",
                Situacao = true
            },
            new UsuarioModel()
            {
                Id = 2,
                Usuario = "LucasFelipe",
                Nome = "Lucas Felipe",
                Cargo = "Atendente",
                Senha = "123456",
                Situacao = false
            },
            new UsuarioModel()
            {
                Id = 3,
                Usuario = "FernandaSilva",
                Nome = "Fernanda Silva",
                Cargo = "Compras",
                Senha = "123456",
                Situacao = true
            },
            new UsuarioModel()
            {
                Id = 4,
                Usuario = "LorenaRodrigues",
                Nome = "Lorena Rodrigues",
                Cargo = "Compras",
                Senha = "123456",
                Situacao = false
            }

        };





        public List<UsuarioModel> CriarUsuario(UsuarioModel usuarioModel)
        {

            usuarioModel.Id = usuarios.Count() + 1;
            usuarios.Add(usuarioModel);
            return usuarios;
        }

        public List<UsuarioModel> ListarUsuarios()
        {
            return usuarios;
        }
    }
}
