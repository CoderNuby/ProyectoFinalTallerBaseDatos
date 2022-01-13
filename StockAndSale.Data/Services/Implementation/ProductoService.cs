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
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepo;
        private readonly IMapper _mapper;
        public ProductoService(IProductoRepository productoRepo, IMapper mapper)
        {
            _productoRepo = productoRepo;
            _mapper = mapper;
        }
        public ProductoViewModel AddProducto(ProductoViewModel productoVM)
        {
            productoVM.ProductoPrecio.CalcularPrecioConIva();

            var saveDate = DateTime.Now;

            var productoEntity = _mapper.Map<Producto>(productoVM);
            productoEntity.EtiquetasFila = productoVM.Estilo + productoVM.Color + productoVM.Talla;
            productoEntity.CreatedBy = 1;
            productoEntity.CreatedDate = saveDate;
            productoEntity.ModifyBy = 1;
            productoEntity.ModifyDate = saveDate;
            productoEntity.IsActive = true;
            productoEntity.ProductoPrecio.CreatedDate = saveDate;
            productoEntity.ProductoPrecio.ModifyDate = saveDate;
            productoEntity.ProductoPrecio.CreatedBy = "CAMBIAR EL STRING";
            productoEntity.ProductoPrecio.ModifyBy = "CAMBIAR EL STRING";

            productoEntity = _productoRepo.Add(productoEntity, true);

            var result = _mapper.Map<ProductoViewModel>(productoEntity);

            return result;
        }

        public ProductoViewModel DeleteProducto(int id)
        {
            var producto = _productoRepo.Get(id);

            producto.IsActive = false;

            producto = _productoRepo.Update(producto, producto.Id, true);

            var result = _mapper.Map<ProductoViewModel>(producto);

            return result;
        }

        public ProductoViewModel GetProducto(int id)
        {
            var producto = _productoRepo.Get(id);

            var result = _mapper.Map<ProductoViewModel>(producto);

            return result;
        }

        public IEnumerable<ProductoViewModel> GetProductos()
        {
            var products = _productoRepo.GetAll();

            var result = _mapper.Map<IEnumerable<ProductoViewModel>>(products);

            return result.OrderBy(u => u.Estilo);
        }

        public ProductoViewModel UpdateProducto(ProductoViewModel productoVM)
        {
            var productoEntity = _productoRepo.Get(productoVM.Id);
            productoEntity.Estilo = productoVM.Estilo;
            productoEntity.Descripcion = productoVM.Descripcion;
            productoEntity.Color = productoVM.Color;
            productoEntity.Talla = productoVM.Talla;
            productoEntity.EtiquetasFila = productoVM.Estilo + productoVM.Color + productoVM.Talla;
            productoEntity.Clasificacion = productoVM.Clasificacion;
            productoEntity.CodigoETC = productoVM.CodigoETC;
            productoEntity.ModifyBy = 1;
            productoEntity.ModifyDate = DateTime.Now;

            productoEntity = _productoRepo.Update(productoEntity, productoEntity.Id, true);

            var result = _mapper.Map<ProductoViewModel>(productoEntity);

            return result;
        }
    }
}
