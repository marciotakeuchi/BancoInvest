using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoInvest.Domain.Entities;

namespace BancoInvest.Domain.Interfaces
{
    public interface IContaCorrenteRepository
    {
        Task<ContaCorrente> GetConta(int numero, int agencia);
        Task<List<ContaCorrente>> GetContasByClientId(int clienteId);
        Task<List<ContaCorrente>> GetAll();

        void Insert(ContaCorrente conta); 
        void Update(ContaCorrente conta);
        void Delete(ContaCorrente conta);
    }
}
