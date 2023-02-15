using AutoMapper;
using BancoInvest.Application.Interfaces;
using BancoInvest.Application.ViewModel;
using BancoInvest.Domain.Entities;
using BancoInvest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Application.Services
{
    public class ClienteServices : IClienteServices
    {
        private IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteServices( IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;  
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            var cliente = _clienteRepository.GetCliente(id).Result;
            _clienteRepository.Delete(cliente);
        }

        public async Task<List<ClienteViewModel>> GetAll()
        {
            var resultado = await _clienteRepository.GetAll();
            return _mapper.Map<List<ClienteViewModel>>(resultado);
        }

        public async Task<ClienteViewModel> GetCliente(int id)
        {
            var resultado =  await _clienteRepository.GetCliente(id);
            return _mapper.Map<ClienteViewModel>(resultado);
        }

        public void Insert(ClienteViewModel cliente)
        {
            Cliente clienteConvertido = _mapper.Map<Cliente>(cliente);
            _clienteRepository.Insert(clienteConvertido);
        }

        public void Update(ClienteViewModel cliente)
        {
            Cliente clienteConvertido = _mapper.Map<Cliente>(cliente);
            _clienteRepository.Update(clienteConvertido);
        }

        public async Task<ClienteViewModel> ConsultaLogin(string login)
        {
            var resultado =  await _clienteRepository.ConsultaLogin(login);
            return _mapper.Map<ClienteViewModel>(resultado);

        }
    }
}
