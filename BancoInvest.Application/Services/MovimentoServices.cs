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
    public class MovimentoServices : IMovimentoServices
    {
        private IMovimentoRepository _movimentoRepository;
        private readonly IMapper _mapper;
        public MovimentoServices(IMovimentoRepository movimentoRepository, IMapper mapper)
        {
            _movimentoRepository = movimentoRepository;
            _mapper = mapper;
        }

        public async Task<List<MovimentoViewModel>> GetAll()
        {
          var resultado = await _movimentoRepository.GetAll();
            return _mapper.Map<List<MovimentoViewModel>>(resultado);
        }

        public async Task<MovimentoViewModel> GetMovimento(int id)
        {
            var resultado = await _movimentoRepository.GetMovimento(id);
            return _mapper.Map<MovimentoViewModel>(resultado);  
        }

        public async Task<List<MovimentoViewModel>> GetMovimentosByClientId(int clienteId)
        {
            var resultado = await _movimentoRepository.GetMovimentosByClientId(clienteId);
            return _mapper.Map<List<MovimentoViewModel>>(resultado);
        }

        public void Insert(MovimentoViewModel movimento)
        {
            _movimentoRepository.Insert(_mapper.Map<Movimento>(movimento));
        }

        public void Update(MovimentoViewModel movimento)
        {
            _movimentoRepository.Update(_mapper.Map<Movimento>(movimento));
        }
        public async void Delete(int id)
        {
            var movimento = await _movimentoRepository.GetMovimento(id);
            _movimentoRepository.Delete(movimento);
        }
    }
}
