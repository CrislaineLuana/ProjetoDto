using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDto.Models;
using ProjetoDto.Services.Usuario;

namespace ProjetoDto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {


        private readonly IUsuarioInterface _usuarioInterface;
        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }


        [HttpGet]
        public ActionResult<List<UsuarioModel>> ListarUsuarios()
        {
            return _usuarioInterface.ListarUsuarios();
        }

        [HttpPost]
        public ActionResult<List<UsuarioModel>> CriarUsuario(UsuarioModel usuarioModel)
        {
            return _usuarioInterface.CriarUsuario(usuarioModel);
        }



    }
}
