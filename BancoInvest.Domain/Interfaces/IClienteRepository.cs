using BancoInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> ConsultaLogin(string login);
        Task<Cliente> GetCliente(int id);
        Task<List<Cliente>> GetAll();
        
        void Insert(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);


    }
}
