using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories
{
    public interface IInventarioMovimientoRepository : IRepository<InventarioMovimiento>
    {
        int GetInventarioByProducto(int productoId);
    }
}
