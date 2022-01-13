using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class Inventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int InventarioSugerido { get; set; }
        public int Existencia { get; set; }
        public bool IsActive { get; set; }

        #region Navigation Properties
        public Producto Producto { get; set; }
        #endregion
    }
}
