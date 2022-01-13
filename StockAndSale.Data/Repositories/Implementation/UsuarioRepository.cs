using AutoMapper;
using StockAndSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class UsuarioRepository : Repository<StockAndSalesContext,Usuario>, IUsuarioRepository
    {
        private readonly IMapper _mapper;

        public UsuarioRepository(StockAndSalesContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
    }
}
