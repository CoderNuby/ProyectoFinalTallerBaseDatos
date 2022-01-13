using AutoMapper;
using StockAndSale.Data.Entities;
using StockAndSale.Data.Models;
using StockAndSale.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services.Implementation
{
    public class InventarioService : IInventarioService
    {
        private readonly IInventarioRepository _inventarioRepo;
        private readonly IInventarioMovimientoRepository _inventarioMovimientoRepo;
        private readonly IMapper _mapper;

        public InventarioService(IInventarioRepository inventarioRepo, IInventarioMovimientoRepository inventarioMovimientoRepo, IMapper mapper)
        {
            _inventarioRepo = inventarioRepo;
            _inventarioMovimientoRepo = inventarioMovimientoRepo;
            _mapper = mapper;
        }
        public InventarioViewModel AddInventario(InventarioViewModel inventarioVM)
        {
            var inventarioEntity = _mapper.Map<Inventario>(inventarioVM);

            inventarioEntity.IsActive = true;

            inventarioEntity = _inventarioRepo.Add(inventarioEntity, true);

            var result = _mapper.Map<InventarioViewModel>(inventarioEntity);

            return result;
        }

        public InventarioViewModel DeleteInventario(int id)
        {
            var inventarioEntity = _inventarioRepo.Get(id);

            inventarioEntity.IsActive = false;

            inventarioEntity = _inventarioRepo.Update(inventarioEntity, inventarioEntity.Id, true);

            var result = _mapper.Map<InventarioViewModel>(inventarioEntity);

            return result;
        }

        public InventarioViewModel GetInventario(int id)
        {
            var inventario = _inventarioRepo.Get(id);

            var result = _mapper.Map<InventarioViewModel>(inventario);

            return result;
        }

        public IEnumerable<InventarioViewModel> GetInventarios()
        {
            var inventarios = _inventarioRepo.GetAll();

            var result = _mapper.Map<IEnumerable<InventarioViewModel>>(inventarios);

            return result;
        }

        public InventarioViewModel UpdateInventario(InventarioViewModel inventarioVM)
        {
            var inventarioEntity = _mapper.Map<Inventario>(inventarioVM);

            inventarioEntity = _inventarioRepo.Update(inventarioEntity, inventarioEntity.Id, true);

            var result = _mapper.Map<InventarioViewModel>(inventarioEntity);

            return result;
        }

        public InventarioMovimientoViewModel AddInventarioMovimiento(InventarioMovimientoViewModel inventarioMovimientoVM)
        {
            var inventarioMovimientoEntity = _mapper.Map<InventarioMovimiento>(inventarioMovimientoVM);
            inventarioMovimientoEntity.FechaMovimiento = DateTime.Now;
            inventarioMovimientoEntity.CreatedBy = "CAMBIAR POR EL NOMBRE DEL QUE LO CREO";

            inventarioMovimientoEntity = _inventarioMovimientoRepo.Add(inventarioMovimientoEntity, true);

            var tipoMovimiento = inventarioMovimientoVM.TipoMovimientoId;
            if (tipoMovimiento == (int)TipoMovimientoEnum.VENTA || tipoMovimiento == (int)TipoMovimientoEnum.EXTRAVIO
                || tipoMovimiento == (int)TipoMovimientoEnum.MERMA || tipoMovimiento == (int)TipoMovimientoEnum.AJUSTE)
            {
                DisminuirExistencia(inventarioMovimientoEntity.InventarioId, inventarioMovimientoEntity.Cantidad);
            }else if (tipoMovimiento == (int)TipoMovimientoEnum.DEVOLUCION || tipoMovimiento == (int)TipoMovimientoEnum.INICIALIZACION
                || tipoMovimiento == (int)TipoMovimientoEnum.COMPRA)
            {
                AgragarExistencia(inventarioMovimientoEntity.InventarioId, inventarioMovimientoEntity.Cantidad);
            }

            var result = _mapper.Map<InventarioMovimientoViewModel>(inventarioMovimientoEntity);

            return result;
        }

        #region Metodos Privados
        private void AgragarExistencia(int inventarioId, int numeroPiezas)
        {
            var inventarioEntity = _inventarioRepo.Get(inventarioId);

            inventarioEntity.Existencia = inventarioEntity.Existencia + numeroPiezas;

            _inventarioRepo.Update(inventarioEntity, inventarioId, true);
        }

        private void DisminuirExistencia(int inventarioId, int numeroPiezas)
        {
            var inventarioEntity = _inventarioRepo.Get(inventarioId);

            inventarioEntity.Existencia = inventarioEntity.Existencia - numeroPiezas;

            _inventarioRepo.Update(inventarioEntity, inventarioId, true);
        }
        #endregion
    }
}
