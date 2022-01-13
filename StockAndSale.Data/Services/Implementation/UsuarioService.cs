using AutoMapper;
using StockAndSale.Data.Entities;
using StockAndSale.Data.Models;
using StockAndSale.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace StockAndSale.Data.Services.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        public IUsuarioRepository _usuarioRepo;
        public IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepo, IMapper mapper)
        {
            _usuarioRepo = usuarioRepo;
            _mapper = mapper;
        }

        public IEnumerable<UsuarioViewModel> GetUsuarios()
        {
            var usuarios = _usuarioRepo.GetAll();

            var result = _mapper.Map<IEnumerable<UsuarioViewModel>>(usuarios);

            return result.OrderBy(u => u.Nombres);
        }

        public UsuarioViewModel GetUsuario(int id)
        {
            var usuario = _usuarioRepo.Get(id);

            var result = _mapper.Map<UsuarioViewModel>(usuario);

            return result;
        }

        public UsuarioViewModel AddUsuario(UsuarioViewModel usuarioVM)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioVM);
            usuarioEntity.IsActive = true;

            usuarioEntity = _usuarioRepo.Add(usuarioEntity, true);

            var result = _mapper.Map<UsuarioViewModel>(usuarioEntity);

            return result;
        }

        public UsuarioViewModel UpdateUsuario(UsuarioViewModel usuarioVM)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioVM);

            usuarioEntity = _usuarioRepo.Update(usuarioEntity, usuarioEntity.Id, true);

            var result = _mapper.Map<UsuarioViewModel>(usuarioEntity);

            return result;
        }

        public UsuarioViewModel DeleteUsuario(int id)
        {
            var usuario = _usuarioRepo.Get(id);

            usuario.IsActive = false;

            usuario = _usuarioRepo.Update(usuario, usuario.Id, true);

            var result = _mapper.Map<UsuarioViewModel>(usuario);

            return result;
        }

        #region Metodos Privados
        #endregion
    }
}
