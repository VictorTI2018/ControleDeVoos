using ControleDeVoos.Domain.Core.Interfaces.Services;
using ControleDeVoos.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.CrossCutting.IOC
{
    public static class ServicesDependency
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceInformacaoVoo, ServiceInformacaoVoo>();
        }
    }
}
