using BancoInvest.Application.Interfaces;
using BancoInvest.Application.Services;
using BancoInvest.Domain.Interfaces;
using BancoInvest.Infra.Data.Context;
using BancoInvest.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BancoInvest.Infra.IoC
{
    public static class DependencyInjection
    {
        public static WebApplicationBuilder AddInfrastruture(this WebApplicationBuilder builder )
        {
            var connectionString = builder.Configuration.GetConnectionString("StringConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);

            });

            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IClienteServices, ClienteServices>();

            return builder;
        }
    }
}
