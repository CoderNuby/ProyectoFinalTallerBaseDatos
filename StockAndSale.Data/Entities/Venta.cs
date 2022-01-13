using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VentaUsuarioId { get; set; }
        public string FormaPago { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Importe { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ImporteIVA { get; set; }
        public string OrdenDeCompra { get; set; }
        public string ReferenciaCompra { get; set; }
        public bool FacturaDespues { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool IsValid { get; set; }
        public bool IsClosed { get; set; }
        public string Observacion { get; set; }
        public string RazonCancelacion { get; set; }
        public bool IsLegacy { get; set; }

        #region Navigation Properties
        [ForeignKey("VentaUsuarioId")]
        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<VentaDetalle> VentasDetalle { get; set; }
        #endregion
    }
}
