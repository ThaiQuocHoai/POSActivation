
/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using POSActivation.DataService.Models;
using Microsoft.Extensions.DependencyInjection;
using POSActivation.DataService.Services;
using POSActivation.DataService.Repositories;
using Microsoft.EntityFrameworkCore;
using Reso.Core.BaseConnect;
namespace POSActivation.DataService.Commons
{
    public static class DependencyInjectionResolverGen
    {
        public static void InitializerDI(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, POSActivationDBContext>();
        
            services.AddScoped<IAspNetRoleService, AspNetRoleService>();
            services.AddScoped<IAspNetRoleRepository, AspNetRoleRepository>();
        
            services.AddScoped<IAspNetRoleClaimService, AspNetRoleClaimService>();
            services.AddScoped<IAspNetRoleClaimRepository, AspNetRoleClaimRepository>();
        
            services.AddScoped<IAspNetUserService, AspNetUserService>();
            services.AddScoped<IAspNetUserRepository, AspNetUserRepository>();
        
            services.AddScoped<IAspNetUserClaimService, AspNetUserClaimService>();
            services.AddScoped<IAspNetUserClaimRepository, AspNetUserClaimRepository>();
        
            services.AddScoped<IAspNetUserLoginService, AspNetUserLoginService>();
            services.AddScoped<IAspNetUserLoginRepository, AspNetUserLoginRepository>();
        
            services.AddScoped<IAspNetUserRoleService, AspNetUserRoleService>();
            services.AddScoped<IAspNetUserRoleRepository, AspNetUserRoleRepository>();
        
            services.AddScoped<IAspNetUserTokenService, AspNetUserTokenService>();
            services.AddScoped<IAspNetUserTokenRepository, AspNetUserTokenRepository>();
        
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();
        
            services.AddScoped<ILocalMachineService, LocalMachineService>();
            services.AddScoped<ILocalMachineRepository, LocalMachineRepository>();
        
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IStoreRepository, StoreRepository>();
        }
    }
}
