using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class InventarioRepository : Repository<StockAndSalesContext, Inventario>, IInventarioRepository
    {
        public InventarioRepository(StockAndSalesContext context) : base(context)
        {

        }
    }
}
