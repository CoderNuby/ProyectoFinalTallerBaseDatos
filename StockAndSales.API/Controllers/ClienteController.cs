using Microsoft.AspNetCore.Mvc;
using StockAndSale.Data.Models;
using StockAndSale.Data.Services;

namespace StockAndSales.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService) : base()
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = _clienteService.GetClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var cliente = _clienteService.GetCliente(id);

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteViewModel clineteVM)
        {
            var clinete = _clienteService.AddCliente(clineteVM);

            return Ok(clinete);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClienteViewModel clienteVM)
        {
            var cliente = _clienteService.UpdateCliente(clienteVM);

            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _clienteService.DeleteCliente(id);

            return Ok(cliente);
        }
    }
}
