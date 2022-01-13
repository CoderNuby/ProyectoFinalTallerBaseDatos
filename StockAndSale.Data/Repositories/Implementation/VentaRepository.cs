using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class VentaRepository : Repository<StockAndSalesContext, Venta>, IVentaRepository
    {
        public VentaRepository(StockAndSalesContext context) : base(context)
        {

        }
    }
}
