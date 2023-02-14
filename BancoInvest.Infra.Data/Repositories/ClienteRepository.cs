using BancoInvest.Domain.Entities;
using BancoInvest.Domain.Interfaces;
using BancoInvest.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return  await _context.Clientes.FindAsync(id);
        }
        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public void Insert(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }
        public void Delete(Cliente cliente)
        {
            _context.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
