using ControleDeVoos.Domain.Core.Interfaces.Repository;
using ControleDeVoos.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.CrossCutting.IOC
{
    public static class RepositoryDependency
    {
        public static void AddReposioryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryInformacaoVoo, RepositoryInformacaoVoo>();
        }
    }
}
