using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.Dtos;

namespace UsuarioApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto usuarioDto)
        {
            throw new NotImplementedException();
        }
    
    }
}
