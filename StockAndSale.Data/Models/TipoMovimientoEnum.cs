using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public enum TipoMovimientoEnum
    {
        VENTA = 1,
        COMPRA = 2,
        MERMA = 3,
        DEVOLUCION = 4,
        EXTRAVIO = 5,
        AJUSTE = 6,
        INICIALIZACION = 7
    }
}
