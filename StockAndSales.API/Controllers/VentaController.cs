using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Models;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;
        public VentaController(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        [HttpGet]
        public IActionResult GetVentas()
        {
            var ventas = _ventaService.GetVentas();

            return Ok(ventas);
        }

        [HttpPost]
        public IActionResult AddVenta([FromBody] VentaViewModel ventaVM)
        {
            var venta = _ventaService.AddVenta(ventaVM);

            return Ok(venta);
        }
    }
}
