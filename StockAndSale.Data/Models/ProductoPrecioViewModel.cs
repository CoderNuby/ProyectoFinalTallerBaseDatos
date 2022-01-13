using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class ProductoPrecioViewModel
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PrecioDescuento { get; set; }
        public decimal PrecioMayoreoIVA { get; set; }
        public decimal PrecioMenudeoIVA { get; set; }
        public decimal PrecioMenudeo { get; set; }
        public decimal Costo { get; set; }

        #region Metodos
        public void CalcularPrecioConIva()
        {
            PrecioMayoreoIVA = PrecioMayoreo + (PrecioMayoreo * 16 / 100);
            PrecioMenudeoIVA = PrecioMenudeo + (PrecioMenudeo * 16 / 100);
        }
        #endregion
    }
}
