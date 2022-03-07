using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using POSActivation.config;
using POSActivation.DataService.Commons;
using POSActivation.DataService.Models;
using POSActivation.DataService.Services;
using Reso.Core.Extension;
using System.Text;

namespace POSActivation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(MyAllowSpecificOrigins,
            //        builder =>
            //        {
            //            builder
            //            .WithOrigins(GetDomain())
            //            //.AllowAnyOrigin()
            //            .AllowAnyHeader()
            //            .AllowAnyMethod();
            //        });
            //});
            //services.ConfigureFilter<ErrorHandlingFilter>();
            services.JsonFormatConfig();
            services.ConfigureSwagger();
            services.ConfigAuthor<AspNetUser, AspNetRole, POSActivationDBContext>();
            services.AddDbContext<POSActivationDBContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("posactivation")));


            //        services.AddIdentity<IdentityUser, IdentityRole>(
            //    options =>
            //    {
            //        options.SignIn.RequireConfirmedAccount = false;

            //        //Other options go here
            //    }
            //    )
            //.AddEntityFrameworkStores<POSActivationDBContext>();

            services.ConfigMemoryCacheAndRedisCache(Configuration["Endpoint:RedisEndpoint"]);

            services.ConfigureDI();
            //services.ConfigureServiceWorkers();
            services.ConfigDataProtection();
            services.ConfigureAutoMapper();
            services.ConfigDependencyGen();
            services.InitializerDI();
            //SwaggerConfig.ConfigureServices(services);
            //services.AuthConfigServices();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            //app.UseCors(MyAllowSpecificOrigins);
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            //app.ConfigMigration<Reso_SaleContext>();
#if !DEBUG
            //app.UseMiddleware<RequestHandler>();
#endif
            app.ConfigureErrorHandler(env);
            app.UseRouting();
            app.ConfigureAuthor();
            app.Configure(env);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.ConfigureSwagger(provider);
        }

    }
}
