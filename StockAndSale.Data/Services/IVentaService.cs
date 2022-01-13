using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services
{
    public interface IVentaService
    {
        IEnumerable<VentaViewModel> GetVentas();
        VentaViewModel GetVenta(int id);
        VentaViewModel AddVenta(VentaViewModel ventaVM);
        VentaViewModel UpdateVenta(VentaViewModel ventaVM);
        VentaViewModel DeleteVenta(int id);
    }
}
