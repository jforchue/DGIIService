using DGIIService.Application;
using DGIIService.Domain.Repositories;
using DGIIService.Domain.Services;
using DGIIService.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            //repositories
            services.AddScoped<IContribuyenteRepository, ContribuyenteRepository>();

            //services
            services.AddScoped<IContribuyenteService, ContribuyenteService>();

            return services;
        }
    }
}
