using BancoInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Domain.Interfaces
{
    public interface IMovimentoRepository
    {
        Task<Movimento> GetMovimento(int id);
        Task<List<Movimento>> GetMovimentosByClientId(int clienteId);
        Task<List<Movimento>> GetAll();

        void Insert(Movimento movimento);
        void Update(Movimento movimento);
        void Delete(Movimento movimento);
    }
}
