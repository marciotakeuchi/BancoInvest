using BancoInvest.Application.ViewModel;

namespace BancoInvest.Application.Interfaces
{
    public interface IContaCorrenteServices
    {
        Task<ContaCorrenteViewModel> GetConta(int numero, int agencia);
        Task<List<ContaCorrenteViewModel>> GetContasByClientId(int clienteId);
        Task<List<ContaCorrenteViewModel>> GetAll();

        void Insert(ContaCorrenteViewModel conta); 
        void Update(ContaCorrenteViewModel conta);
        void Delete(int numero, int agencia);
    }
}
