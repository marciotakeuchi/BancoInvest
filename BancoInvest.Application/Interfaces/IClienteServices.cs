using BancoInvest.Application.ViewModel;

namespace BancoInvest.Application.Interfaces
{
    public interface IClienteServices
    {
        Task<ClienteViewModel> GetCliente(int id);
        Task<List<ClienteViewModel>> GetAll();

        Task<ClienteViewModel> ConsultaLogin(string login);

        void Insert(ClienteViewModel cliente);
        void Update(ClienteViewModel cliente);
        void Delete(int id);

        
    }
}
