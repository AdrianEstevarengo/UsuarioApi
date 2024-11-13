using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Models;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _UsuarioService;
        public UsuarioController(UsuarioService usuarioService)
        {
            _UsuarioService = usuarioService;
        }

        [HttpPost("cadastra")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _UsuarioService.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }


        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUsuarioDto dto)
        {
            await _UsuarioService.Login(dto);
            return Ok("Usuário autenticado!");
        }
    }
}
