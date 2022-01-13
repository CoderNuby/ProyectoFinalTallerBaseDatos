using StockAndSale.Data.Models;
using System.Collections.Generic;

namespace StockAndSale.Data.Services
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioViewModel> GetUsuarios();
        UsuarioViewModel GetUsuario(int id);
        UsuarioViewModel AddUsuario(UsuarioViewModel usuarioVM);
        UsuarioViewModel UpdateUsuario(UsuarioViewModel usuarioVM);
        UsuarioViewModel DeleteUsuario(int id);
    }
}
