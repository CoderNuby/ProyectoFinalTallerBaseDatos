using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services
{
    public interface IInventarioService
    {
        IEnumerable<InventarioViewModel> GetInventarios();
        InventarioViewModel GetInventario(int id);
        InventarioViewModel AddInventario(InventarioViewModel inventarioVM);
        InventarioViewModel UpdateInventario(InventarioViewModel inventarioVM);
        InventarioViewModel DeleteInventario(int id);
        InventarioMovimientoViewModel AddInventarioMovimiento(InventarioMovimientoViewModel inventarioMovimientoVM);
    }
}
