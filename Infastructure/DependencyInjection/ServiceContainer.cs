using Application.Services.GetFoodByCode;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection InfastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFood, FoodService>();

            return services;
        }
    }
}
