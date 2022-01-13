using Microsoft.EntityFrameworkCore;
using StockAndSale.Data.Entities;
using System;

namespace StockAndSale.Data
{
    public class StockAndSalesContext : DbContext
    {
        public StockAndSalesContext(DbContextOptions<StockAndSalesContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoPrecio> ProductoPrecios { get; set;}

        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }

        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<InventarioMovimiento> InventarioMovimientos { get; set; }

        public DbSet<Venta> Venta { get; set; }
        public DbSet<VentaDetalle> VentaDetalle { get; set; }

    }
}
