using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Clave { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Calle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string Colonia { get; set; }
        public string EntreCalles { get; set; }
        public string CP { get; set; }
        public string Contacto { get; set; }
        public byte[] Foto { get; set; }
    }
}
