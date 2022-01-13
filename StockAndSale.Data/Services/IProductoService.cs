using StockAndSale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Services
{
    public interface IProductoService
    {
        IEnumerable<ProductoViewModel> GetProductos();
        ProductoViewModel GetProducto(int id);
        ProductoViewModel AddProducto(ProductoViewModel productoVM);
        ProductoViewModel UpdateProducto(ProductoViewModel productoVM);
        ProductoViewModel DeleteProducto(int id);
    }
}
