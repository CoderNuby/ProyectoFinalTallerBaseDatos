using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class InventarioMovimiento
    {
        public int Id { get; set; }
        public int InventarioId { get; set; }
        public int TipoMovimientoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string CreatedBy { get; set; }
    }
}
