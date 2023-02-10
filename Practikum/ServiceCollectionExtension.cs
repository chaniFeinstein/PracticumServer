using Common.DTO_s;
using DBContext;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Repositories;
using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IService<UserDTO>, UserService>();
            services.AddSingleton<IContext, Context>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
