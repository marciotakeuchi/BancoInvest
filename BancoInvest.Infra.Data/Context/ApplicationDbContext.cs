using BancoInvest.Domain.Entities;
using BancoInvest.Infra.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace BancoInvest.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<ContaCorrente> ContaCorrentes { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContaCorrenteMap());
            modelBuilder.ApplyConfiguration(new MovimentoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
