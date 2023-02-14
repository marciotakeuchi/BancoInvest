using AutoMapper;
using BancoInvest.Application.ViewModel;
using BancoInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Application.Mapping
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public DomainToViewModelMappingProfile() { 
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ContaCorrente, ContaCorrenteViewModel>();
            CreateMap<Movimento, MovimentoViewModel>(); 
        }
    }
}
