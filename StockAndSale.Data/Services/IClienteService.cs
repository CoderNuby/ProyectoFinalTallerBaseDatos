using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services
{
    public interface IClienteService
    {
        IEnumerable<ClienteViewModel> GetClientes();
        ClienteViewModel GetCliente(int id);
        ClienteViewModel AddCliente(ClienteViewModel clienteVM);
        ClienteViewModel UpdateCliente(ClienteViewModel clienteVM);
        ClienteViewModel DeleteCliente(int id);
    }
}
