using AutoMapper;
using StockAndSale.Data.Entities;
using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Producto, ProductoViewModel>()
                .ForMember(p => p.ProductoPrecio, options => options.MapFrom(p => p.ProductoPrecio))
                .ReverseMap();
            CreateMap<ProductoPrecio, ProductoPrecioViewModel>().ReverseMap();
            CreateMap<Inventario, InventarioViewModel>().ReverseMap();
            CreateMap<TipoMovimiento, TipoMovimientoViewModel>().ReverseMap();
            CreateMap<InventarioMovimiento, InventarioMovimientoViewModel>().ReverseMap();
            CreateMap<Venta, VentaViewModel>().ReverseMap();
            CreateMap<VentaDetalle, VentaDetalleViewModel>().ReverseMap();
        }
    }
}
