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
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private readonly ApplicationDbContext _context;
        public ContaCorrenteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ContaCorrente>> GetAll()
        {
            return await _context.ContaCorrentes.ToListAsync();
        }

        public async Task<ContaCorrente> GetConta(int numero, int agencia)
        {
            return await _context.ContaCorrentes
                .Where(x => x.Numero == numero && x.Agencia == agencia)
                .FirstAsync();
        }

        public async Task<List<ContaCorrente>> GetContasByClientId(int clienteId)
        {
            return await _context.ContaCorrentes
                 .Where(x => x.ClienteId == clienteId)
                 .ToListAsync();
        }

        public void Insert(ContaCorrente conta)
        {
            _context.Add(conta);
            _context.SaveChanges();
        }

        public void Update(ContaCorrente conta)
        {
            _context.Update(conta);
            _context.SaveChanges();

        }
        public void Delete(ContaCorrente conta)
        {
            _context.Remove(conta);
            _context.SaveChanges();
        }
    }
}
