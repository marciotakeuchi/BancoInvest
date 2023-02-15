using AutoMapper;
using BancoInvest.Application.ViewModel;
using BancoInvest.Domain.Entities;

namespace BancoInvest.Application.Mapping
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ContaCorrenteViewModel,ContaCorrente>();
            CreateMap<MovimentoViewModel, Movimento>();
        }
    }
}
