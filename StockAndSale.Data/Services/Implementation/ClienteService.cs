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
    public class ClienteService : IClienteService
    {
        public IClienteRepository _clienteRepo;
        public IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepo, IMapper mapper)
        {
            _clienteRepo = clienteRepo;
            _mapper = mapper;
        }

        public IEnumerable<ClienteViewModel> GetClientes()
        {
            var clientes = _clienteRepo.GetAll();

            var result = _mapper.Map<IEnumerable<ClienteViewModel>>(clientes);

            return result.OrderBy(u => u.RazonSocial);
        }

        public ClienteViewModel GetCliente(int id)
        {
            var cliente = _clienteRepo.Get(id);

            var result = _mapper.Map<ClienteViewModel>(cliente);

            return result;
        }

        public ClienteViewModel AddCliente(ClienteViewModel clienteVM)
        {
            var clienteEntity = _mapper.Map<Cliente>(clienteVM);
            clienteEntity.IsActive = true;
            clienteEntity.CreatedBy = "CAMBIAR NOMBRE DEL QUE LO CREO";
            clienteEntity.ModifiedBy = "CAMBIAR NOMBRE DEL QUE LO MODIFICO";
            clienteEntity.CreatedDate = DateTime.Now;
            clienteEntity.ModifiedDate = DateTime.Now;


            clienteEntity = _clienteRepo.Add(clienteEntity, true);

            var result = _mapper.Map<ClienteViewModel>(clienteEntity);

            return result;
        }

        public ClienteViewModel UpdateCliente(ClienteViewModel clienteVM)
        {
            var clienteEntity = _clienteRepo.Get(clienteVM.Id);
            clienteEntity.RazonSocial = clienteVM.RazonSocial;
            clienteEntity.Clave = clienteVM.Clave;
            clienteEntity.RFC = clienteVM.RFC;
            clienteEntity.CURP = clienteVM.CURP;
            clienteEntity.Calle = clienteVM.Calle;
            clienteEntity.NumeroExterior = clienteVM.NumeroExterior;
            clienteEntity.NumeroInterior = clienteVM.NumeroInterior;
            clienteEntity.Colonia = clienteVM.Colonia;
            clienteEntity.EntreCalles = clienteVM.EntreCalles;
            clienteEntity.CP = clienteVM.CP;
            clienteEntity.Contacto = clienteVM.Contacto;
            clienteEntity.Foto = clienteVM.Foto;
            clienteEntity.ModifiedBy = "CAMBIAR A QUIEN LO MODIFICO";
            clienteEntity.ModifiedDate = DateTime.Now;

            clienteEntity = _clienteRepo.Update(clienteEntity, clienteEntity.Id, true);

            var result = _mapper.Map<ClienteViewModel>(clienteEntity);

            return result;
        }

        public ClienteViewModel DeleteCliente(int id)
        {
            var cliente = _clienteRepo.Get(id);

            cliente.IsActive = false;

            cliente = _clienteRepo.Update(cliente, cliente.Id, true);

            var result = _mapper.Map<ClienteViewModel>(cliente);

            return result;
        }

        #region Metodos Privados
        #endregion
    }
}
