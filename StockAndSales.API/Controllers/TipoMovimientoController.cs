using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMovimientoController : ControllerBase
    {
        private readonly ITipoMovimientoService _tipoMovimientoService;

        public TipoMovimientoController(ITipoMovimientoService tipoMovimientoService)
        {
            _tipoMovimientoService = tipoMovimientoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var tiposMovimiento = _tipoMovimientoService.GetTiposMovimiento();

            return Ok(tiposMovimiento);
        }
    }
}
