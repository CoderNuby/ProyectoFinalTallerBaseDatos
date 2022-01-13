using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Models;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly IInventarioService _inventarioService;
        public InventarioController(IInventarioService inventarioService) : base()
        {
            _inventarioService = inventarioService;
        }

        [HttpGet]
        public IActionResult GetInventarios()
        {
            var inventarios = _inventarioService.GetInventarios();
            return Ok(inventarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var inventario = _inventarioService.GetInventario(id);

            return Ok(inventario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] InventarioViewModel inventarioVM)
        {
            var inventario = _inventarioService.AddInventario(inventarioVM);

            return Ok(inventario);
        }

        [HttpPut]
        public IActionResult Put([FromBody] InventarioViewModel inventarioVM)
        {
            var inventario = _inventarioService.UpdateInventario(inventarioVM);

            return Ok(inventario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var inventario = _inventarioService.DeleteInventario(id);

            return Ok(inventario);
        }

        [HttpPost("InventarioMovimiento")]
        public IActionResult Post([FromBody] InventarioMovimientoViewModel inventarioMovimientoVM)
        {
            var inventarioMovimiento = _inventarioService.AddInventarioMovimiento(inventarioMovimientoVM);

            return Ok(inventarioMovimiento);
        }
    }
}
