using BancoInvest.Application.ViewModel;
using BancoInvest.Domain.Entities;

namespace BancoInvest.Application.Security
{
    public interface ISessaoServices
    {
        void CriarSessaoCliente(ClienteViewModel cliente);
        void RemoverSessaoCliente();
        ClienteViewModel BuscarSessaoCliente();

    }
}
