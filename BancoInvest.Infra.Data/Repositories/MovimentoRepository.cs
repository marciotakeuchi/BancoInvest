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
    public class MovimentoRepository : IMovimentoRepository
    {
        private readonly ApplicationDbContext _context;
        public MovimentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movimento>> GetAll()
        {
            return await _context.Movimentos.ToListAsync();
        }

        public async Task<Movimento> GetMovimento(int id)
        {
            return await _context.Movimentos.FindAsync(id);
        }

        public async Task<List<Movimento>> GetMovimentosByClientId(int clienteId)
        {
            return await _context.Movimentos.Where(x => x.ClienteId == clienteId).ToListAsync();
        }

        public void Insert(Movimento movimento)
        {
            _context.Add(movimento);
            _context.SaveChanges();
        }

        public void Update(Movimento movimento)
        {
            _context.Update(movimento);
            _context.SaveChanges();
        }

        public void Delete(Movimento movimento)
        {
            _context.Remove(movimento);
            _context.SaveChanges();
        }
    }
}
