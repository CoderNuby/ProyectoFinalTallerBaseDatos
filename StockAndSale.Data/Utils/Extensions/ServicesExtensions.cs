using Microsoft.Extensions.DependencyInjection;
using StockAndSale.Data.Repositories;
using StockAndSale.Data.Repositories.Implementation;
using StockAndSale.Data.Services;
using StockAndSale.Data.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Utils.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddStockAndSaleServices(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IInventarioRepository, InventarioRepository>();
            services.AddTransient<IInventarioMovimientoRepository, InventarioMovimientoRepository>();
            services.AddTransient<ITipoMovimientoRepository, TipoMovimientoRepository>();
            services.AddTransient<IVentaRepository, VentaRepository>();

            //SERVICIOS INJECTIONS
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<IInventarioService, InventarioService>();
            services.AddTransient<ITipoMovimientoService, TipoMovimientoService>();
            services.AddTransient<IVentaService, VentaService>();
        }
    }
}
