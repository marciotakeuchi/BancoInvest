using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoInvest.Domain.Entities;

namespace BancoInvest.Domain.Interfaces
{
    public interface IContaRepository
    {
        Task<IConta> GetConta(int numero, int agencia);
        Task<List<IConta>> GetContasByClientId(int clienteId);
        Task<List<IConta>> GetAll();

        void Insert(IConta conta); 
        void Update(IConta conta);
        void Delete(IConta conta);
    }
}
