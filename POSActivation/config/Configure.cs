using Microsoft.Extensions.DependencyInjection;
using POSActivation.DataService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.config
{
    public static class Configure
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped<ILocalMachineService, LocalMachineService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IAspNetUserService, AspNetUserService>();
        }
    }
}
