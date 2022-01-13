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
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepo;
        private readonly IMapper _mapper;
        private readonly IInventarioService _inventarioService;
        private readonly IInventarioMovimientoRepository _inventarioMovimientoRepo;

        public VentaService(IVentaRepository ventaRepo, IMapper mapper,
            IInventarioService inventarioService, IInventarioMovimientoRepository inventarioMovimientoRepo)
        {
            _ventaRepo = ventaRepo;
            _mapper = mapper;
            _inventarioService = inventarioService;
            _inventarioMovimientoRepo = inventarioMovimientoRepo;
        }

        public VentaViewModel AddVenta(VentaViewModel ventaVM)
        {
            //CalcularImportes(ventaVM);

            var ventaEntity = _mapper.Map<Venta>(ventaVM);
            ventaEntity.IsLegacy = true;
            ventaEntity.IsValid = true;
            ventaEntity.IsClosed = false;
            ventaEntity.FechaAlta = DateTime.Now;

            ventaEntity = _ventaRepo.Add(ventaEntity, true);

            foreach (var ventaDetalle in ventaEntity.VentasDetalle)
            {
                var inventarioId = _inventarioMovimientoRepo.GetInventarioByProducto(ventaDetalle.ProductoId);
                var inventarioMovimiento = new InventarioMovimientoViewModel()
                {
                    Cantidad = (int)ventaDetalle.Cantidad,
                    Id = 0,
                    InventarioId = inventarioId,
                    TipoMovimientoId = 1
                };

                _inventarioService.AddInventarioMovimiento(inventarioMovimiento);
            }

            var result = _mapper.Map<VentaViewModel>(ventaEntity);

            return result;
        }

        public VentaViewModel DeleteVenta(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaViewModel> GetVentas()
        {
            var ventasEntity = _ventaRepo.GetAll();

            var result = _mapper.Map<IEnumerable<VentaViewModel>>(ventasEntity);

            return result;
        }

        public VentaViewModel GetVenta(int id)
        {
            throw new NotImplementedException();
        }

        public VentaViewModel UpdateVenta(VentaViewModel ventaVM)
        {
            var ventaEntity = _ventaRepo.Get(ventaVM.Id);
            ventaEntity.ClienteId = ventaVM.ClienteId;
            ventaEntity.VentaUsuarioId = ventaVM.VentaUsuarioId;
            ventaEntity.FormaPago = ventaVM.FormaPago;
            ventaEntity.Importe = ventaVM.Importe;
            ventaEntity.ImporteIVA = ventaVM.ImporteIVA;
            ventaEntity.OrdenDeCompra = ventaVM.OrdenDeCompra;
            ventaEntity.ReferenciaCompra = ventaVM.ReferenciaCompra;
            ventaEntity.FacturaDespues = ventaVM.FacturaDespues;
            ventaEntity.Observacion = ventaVM.Observacion;
            ventaEntity.RazonCancelacion = ventaVM.RazonCancelacion;

            ventaEntity = _ventaRepo.Update(ventaEntity, ventaEntity.Id, true);

            var result = _mapper.Map<VentaViewModel>(ventaEntity);

            return result;
        }

        #region Metodos Privados
        private void CalcularImportes(VentaViewModel ventaVM)
        {
            ventaVM.Importe = 0;
            ventaVM.ImporteIVA = 0;

            foreach (var ventaDetalle in ventaVM.VentasDetalle)
            {

            }
        }
        #endregion
    }
}
