using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Models;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService) : base()
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var usuarios = _usuarioService.GetUsuarios();
            //var usuarios = _context.Usuarios.FromSqlRaw("EXEC GetUsuarios").ToList();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            var usuario = _usuarioService.GetUsuario(id);

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody]UsuarioViewModel usuarioVM)
        {
            var usuario = _usuarioService.AddUsuario(usuarioVM);

            return Ok(usuario);
        }

        [HttpPut]
        public IActionResult Put([FromBody]UsuarioViewModel usuarioVM)
        {
            var usuario = _usuarioService.UpdateUsuario(usuarioVM);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _usuarioService.DeleteUsuario(id);

            return Ok(usuario);
        }
    }
}
