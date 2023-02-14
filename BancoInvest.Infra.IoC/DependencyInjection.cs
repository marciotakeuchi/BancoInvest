using BancoInvest.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

            return builder;
        }
    }
}
