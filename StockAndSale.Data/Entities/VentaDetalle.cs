using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class VentaDetalle
    {
        public int ID { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TasaIVA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MontoIVA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ImporteSinIVA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Importe { set; get; }
        public string Observacion { get; set; }

        #region Navigation Properties
        public Venta Venta { get; set; }
        #endregion
    }
}
