

using BancoInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoInvest.Infra.Data.Map
{
    public class MovimentoMap : IEntityTypeConfiguration<Movimento>
    {
        public void Configure(EntityTypeBuilder<Movimento> builder)
        {
            builder.Property(x => x.Resumo).HasMaxLength(500);
        }
    }
}
