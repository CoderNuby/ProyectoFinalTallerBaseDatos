using Microsoft.EntityFrameworkCore;
using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class InventarioMovimientoRepository : Repository<StockAndSalesContext, InventarioMovimiento>, IInventarioMovimientoRepository
    {
        public InventarioMovimientoRepository(StockAndSalesContext context) : base(context)
        {

        }

        public int GetInventarioByProducto(int productoId)
        {
            var inventario = _context.Inventario.ToList().Where(i => i.ProductoId == productoId).FirstOrDefault();

            return inventario.Id;
        }
    }
}
