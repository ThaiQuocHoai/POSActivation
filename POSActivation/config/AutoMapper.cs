using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using POSActivation.DataService.AutoMapperConfig;
using POSActivation.DataService.Models;
using POSActivation.DataService.RequestModel;
using POSActivation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.config
{
    public static class AutoMapperConfig
    {
        public static void ConfigureAutoMapper( this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.ConfigStoreModule();
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
