using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public static class ServicesRepositoriesCollection
    {
        public static void AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IUser<User>,UserRepository>();           
        }
    }
}
