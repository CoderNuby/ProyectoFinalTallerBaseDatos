using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class Cliente
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
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
