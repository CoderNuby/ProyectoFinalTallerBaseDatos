using AutoMapper;
using StockAndSale.Data.Models;
using StockAndSale.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services.Implementation
{
    public class TipoMovimientoService : ITipoMovimientoService
    {
        private readonly ITipoMovimientoRepository _tipoMovimientoRepo;
        private readonly IMapper _mapper;

        public TipoMovimientoService(ITipoMovimientoRepository tipoMovimientoRepo, IMapper mapper)
        {
            _tipoMovimientoRepo = tipoMovimientoRepo;
            _mapper = mapper;
        }

        public IEnumerable<TipoMovimientoViewModel> GetTiposMovimiento()
        {
            var tiposMovimientoEntity = _tipoMovimientoRepo.GetAll();

            var result = _mapper.Map<IEnumerable<TipoMovimientoViewModel>>(tiposMovimientoEntity);

            return result;
        }
    }
}
