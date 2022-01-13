using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class VentaViewModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VentaUsuarioId { get; set; }
        public string FormaPago { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteIVA { get; set; }
        public string OrdenDeCompra { get; set; }
        public string ReferenciaCompra { get; set; }
        public bool FacturaDespues { get; set; }
        public string Observacion { get; set; }
        public string RazonCancelacion { get; set; }

        public List<VentaDetalleViewModel> VentasDetalle { get; set; }
    }
}
