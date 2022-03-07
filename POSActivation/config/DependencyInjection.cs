using Microsoft.Extensions.DependencyInjection;
using POSActivation.DataService.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.config
{
    public static class DependencyInjection
    {
        public static void ConfigDependencyGen(this IServiceCollection services)
        {
            DependencyInjectionResolverGen.InitializerDI(services);
        }
    }
}
