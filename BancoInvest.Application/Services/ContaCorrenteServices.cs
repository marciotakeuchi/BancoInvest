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
    public class ContaCorrenteServices : IContaCorrenteServices
    {
        private IContaCorrenteRepository _contaCorrenteRepository;
        private readonly IMapper _mapper;
        public ContaCorrenteServices(IContaCorrenteRepository contaCorrenteRepository, IMapper mapper)
        {
            _contaCorrenteRepository= contaCorrenteRepository;
            _mapper= mapper;
        }

        public async void Delete(int numero, int agencia)
        {
            var resultado = await _contaCorrenteRepository.GetConta(numero, agencia);
            _contaCorrenteRepository.Delete(resultado);
        }

        public async Task<List<ContaCorrenteViewModel>> GetAll()
        {
            var consulta = await _contaCorrenteRepository.GetAll();
            return _mapper.Map<List<ContaCorrenteViewModel>>(consulta);
        }

        public async Task<ContaCorrenteViewModel> GetConta(int numero, int agencia)
        {
            var consulta = await _contaCorrenteRepository.GetConta(numero, agencia);
            return _mapper.Map<ContaCorrenteViewModel>(consulta);
        }

        public async Task<List<ContaCorrenteViewModel>> GetContasByClientId(int clienteId)
        {
            var consulta = await _contaCorrenteRepository.GetContasByClientId(clienteId);
            return _mapper.Map<List<ContaCorrenteViewModel>>(consulta);
        }

        public void Insert(ContaCorrenteViewModel conta)
        {
            _contaCorrenteRepository.Insert(_mapper.Map<ContaCorrente>(conta));
        }

        public void Update(ContaCorrenteViewModel conta)
        {
            _contaCorrenteRepository.Update(_mapper.Map<ContaCorrente>(conta));
        }
    }
}
