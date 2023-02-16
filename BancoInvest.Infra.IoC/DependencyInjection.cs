using BancoInvest.Application.Interfaces;
using BancoInvest.Application.Security;
using BancoInvest.Application.Services;
using BancoInvest.Domain.Interfaces;
using BancoInvest.Infra.Data.Context;
using BancoInvest.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
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

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IContaCorrenteRepository, ContaCorrenteRepository>();
            builder.Services.AddScoped<IMovimentoRepository, MovimentoRepository>();

            builder.Services.AddScoped<IClienteServices, ClienteServices>();
            builder.Services.AddScoped<IContaCorrenteServices, ContaCorrenteServices>();
            builder.Services.AddScoped<IMovimentoServices, MovimentoServices>();

            builder.Services.AddScoped<ISessaoServices, SessaoServices>();
            builder.Services.AddSession( o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential= true;
            });

            return builder;
        }
    }
}
