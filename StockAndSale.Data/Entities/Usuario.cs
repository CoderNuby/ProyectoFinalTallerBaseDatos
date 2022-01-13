using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
