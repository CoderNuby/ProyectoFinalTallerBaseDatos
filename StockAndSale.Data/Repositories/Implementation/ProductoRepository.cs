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
    public class ProductoRepository : Repository<StockAndSalesContext, Producto>, IProductoRepository
    {
        public ProductoRepository(StockAndSalesContext context) : base(context)
        {

        }

        public IEnumerable<Producto> GetProductoWithPrecio(Expression<Func<Producto, bool>> query)
        {
            var productos = _context.Productos.Include(p => p.ProductoPrecio).
                Where(query);

            return productos;
        }
    }
}
