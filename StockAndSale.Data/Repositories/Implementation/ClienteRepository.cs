using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class ClienteRepository : Repository<StockAndSalesContext, Cliente>, IClienteRepository
    {
        public ClienteRepository(StockAndSalesContext context) : base(context)
        {

        }
    }
}
