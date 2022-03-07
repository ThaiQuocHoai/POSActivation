using AutoMapper;
using POSActivation.DataService.Models;
using POSActivation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSActivation.DataService.AutoMapperConfig
{
    public static class StoreModule
    {
        public static void ConfigStoreModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Store, StoreModel>();
            mc.CreateMap<LocalMachine, LocalMachineModel>();
            mc.CreateMap<Store, StoreValidDateRequestModel>();
            mc.CreateMap<StoreValidDateRequestModel, Store>()
                .ForMember(s => s.Id, st => st.MapFrom(m => m.Id))
                .ForMember(s => s.ValidDate, st => st.MapFrom(m => m.ValidDate)).ReverseMap();
        }
    }
}
