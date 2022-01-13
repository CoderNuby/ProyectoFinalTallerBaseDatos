using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories
{
    public interface IProductoRepository : IRepository<Producto>
    {
        IEnumerable<Producto> GetProductoWithPrecio(Expression<Func<Producto, bool>> query);
    }
}
