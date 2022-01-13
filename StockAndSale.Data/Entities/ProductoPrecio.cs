using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class ProductoPrecio
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMayoreo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioDescuento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMayoreoIVA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMenudeoIVA { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioMenudeo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Costo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }

        #region Navigation Properties
        [ForeignKey("ProductoId")]
        public virtual Producto Producto { get; set; }
        #endregion
    }
}
