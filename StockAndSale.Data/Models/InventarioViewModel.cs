using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class InventarioViewModel
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int InventarioSugerido { get; set; }
        public int Existencia { get; set; }
    }
}
