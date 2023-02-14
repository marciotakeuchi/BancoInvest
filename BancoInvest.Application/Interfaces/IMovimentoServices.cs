using BancoInvest.Application.ViewModel;

namespace BancoInvest.Application.Interfaces
{
    public interface IMovimentoServices
    {
        Task<MovimentoViewModel> GetMovimento(int id);
        Task<List<MovimentoViewModel>> GetMovimentosByClientId(int clienteId);
        Task<List<MovimentoViewModel>> GetAll();

        void Insert(MovimentoViewModel movimento);
        void Update(MovimentoViewModel movimento);
        void Delete(int id);
    }
}
