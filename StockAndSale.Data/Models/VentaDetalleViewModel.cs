using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class VentaDetalleViewModel
    {
        public int ID { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal TasaIVA { get; set; }
        public decimal MontoIVA { get; set; }
        public decimal ImporteSinIVA { get; set; }
        public decimal Importe { set; get; }
        public string Observacion { get; set; }
    }
}
