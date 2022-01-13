using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class TipoMovimientoRepository : Repository<StockAndSalesContext, TipoMovimiento>, ITipoMovimientoRepository
    {
        public TipoMovimientoRepository(StockAndSalesContext context) : base(context)
        {

        }
    }
}
