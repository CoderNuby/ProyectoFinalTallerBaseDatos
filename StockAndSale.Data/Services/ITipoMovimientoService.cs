using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services
{
    public interface ITipoMovimientoService
    {
        IEnumerable<TipoMovimientoViewModel> GetTiposMovimiento();
    }
}
