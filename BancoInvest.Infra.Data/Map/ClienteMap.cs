using BancoInvest.Domain.Entities;
using BancoInvest.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Infra.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeCompleto).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Login).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
            builder.HasMany(x => x.ContaCorrentes);
            builder.ToTable("Cliente");

            builder.HasData(
                new Cliente
                {
                    Id = 1,
                    NomeCompleto = "Joao Pedro Silva",
                    Cpf = "12345678911",
                    DataNascimento = new DateTime(2000, 05, 12),
                    Email = "joao.silva@teste.com",
                    Login = "joao.silva",
                    Password = "0RmgyFBHATgzGX+hbHrxsNbgCIk6tWDUlBt6DK/P/4mvOplZ",
                    Ativo = true,
                },
                  new Cliente
                  {
                      Id = 2,
                      NomeCompleto = "Maria Lima da Costa",
                      Cpf = "98765432100",
                      DataNascimento = new DateTime(2002, 09, 08),
                      Email = "maria.costa@teste.com",
                      Login = "maria.costa",
                      Password = "0RmgyFBHATgzGX+hbHrxsNbgCIk6tWDUlBt6DK/P/4mvOplZ",
                      Ativo = true,
                  }
                  //Password is Teste@1234
                );
        }
    }
}
