using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDto.Dto;
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


     
        [HttpPost]
        public ActionResult<List<UsuarioListagemDto>> CriarUsuario(UsuarioCriacaoDto usuarioModel)
        {
            return _usuarioInterface.CriarUsuario(usuarioModel);
        }



    }
}
