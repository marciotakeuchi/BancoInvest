using BancoInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Infra.Data.Map
{
    public class ContaCorrenteMap : IEntityTypeConfiguration<ContaCorrente>
    {
        public void Configure(EntityTypeBuilder<ContaCorrente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Saldo).HasPrecision(10, 2).IsRequired();
            builder.Property(x => x.LimiteEspecial).HasPrecision(10, 2).IsRequired();
            builder.HasOne(x => x.Cliente);
            builder.ToTable("ContaCorrente");

            builder.HasData(
                new ContaCorrente()
                {
                    Id = Guid.NewGuid(),
                    Numero = 10,
                    Agencia = 1,
                    Saldo = 0,
                    ClienteId = 1,
                    DataCriacao = DateTime.Now,
                    DataAtualizacao = DateTime.Now,
                    Ativo = true
                },
                 new ContaCorrente()
                 {
                     Id = Guid.NewGuid(),
                     Numero = 20,
                     Agencia = 1,
                     Saldo = 0,
                     ClienteId = 2,
                     DataCriacao = DateTime.Now.AddDays(1),
                     DataAtualizacao = DateTime.Now.AddDays(1),
                     Ativo = true
                 }
                );
        }
    }
}
