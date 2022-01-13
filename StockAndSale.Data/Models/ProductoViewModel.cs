using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        public string Estilo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public string EtiquetasFila { get; set; }
        public char Clasificacion { get; set; }
        public string CodigoETC { get; set; }

        public ProductoPrecioViewModel ProductoPrecio { get; set; }
    }
}
