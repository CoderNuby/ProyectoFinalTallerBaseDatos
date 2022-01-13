using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Models;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            var productos = _productoService.GetProductos();

            return Ok(productos);
        }

        [HttpGet("{id}")]
        public IActionResult GetProducto(int id)
        {
            var producto = _productoService.GetProducto(id);

            return Ok(producto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductoViewModel productoVM)
        {
            var producto = _productoService.AddProducto(productoVM);

            return Ok(producto);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ProductoViewModel productoVM)
        {
            var producto = _productoService.UpdateProducto(productoVM);

            return Ok(producto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _productoService.DeleteProducto(id);

            return Ok(producto);
        }
    }
}
