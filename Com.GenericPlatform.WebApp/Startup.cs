using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.EzTender.Repository.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Com.EzTender.Repository;
using Com.EzTender.Common;
using Com.GenericPlatform.Services.Code;

namespace Com.GenericPlatform.WebApp
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
            services.AddMvc();

            // Use a PostgreSQL database
            var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection");

            // TODO: Update in each application
            services.AddDbContext<DatabaseContext>(options =>
                    options.UseMySQL(
                    sqlConnectionString,
                    b => b.MigrationsAssembly("Com.PlatformServices.SystemSettings") // main project name = Application Specific
                )
            );

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            RegisterForDependencyInjection(services);
        }

        public void RegisterForDependencyInjection(IServiceCollection services)
        {
            //// Register for repository
            services.AddScoped<ICodeRepository, CodeRepository>();
            //services.AddScoped<GetMeToMyMechanic.Repository.Declaration.ILocationInformationRepository, GetMeToMyMechanic.Repository.Definition.LocationInformationRepository>();

            //// Register for library
            services.AddScoped<ICodesService, CodesService>();
            //services.AddScoped<GetMeToMyMechanic.Lib.Declaration.ILocationInformationService, GetMeToMyMechanic.Lib.Definition.LocationInformationService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=User}/{action=SignIn}/{id?}");
            });
        }
    }
}
