using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.PlatformServices.Common.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Com.PlatformServices.FileSystem
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
            services.AddDbContext<AppDbContext>(options =>
                    options.UseMySQL(
                    sqlConnectionString,
                    b => b.MigrationsAssembly("Com.PlatformServices.SystemSettings") // main project name = Application Specific
                )
            );

            services.Configure<Configurations.AppSettings>(Configuration.GetSection("AppSettings"));

            RegisterForDependencyInjection(services);
        }

        private void RegisterForDependencyInjection(IServiceCollection services)
        {
            //// Register for repository
            services.AddScoped<Com.PlatformServices.FileSystem.Repository.IFileSystemRepository, Com.PlatformServices.FileSystem.Repository.FileSystemRepository>();
            //services.AddScoped<GetMeToMyMechanic.Repository.Declaration.ILocationInformationRepository, GetMeToMyMechanic.Repository.Definition.LocationInformationRepository>();

            //// Register for library
            services.AddScoped<Com.PlatformServices.FileSystem.Logic.IFileSystemLogic, Com.PlatformServices.FileSystem.Logic.FileSystemLogic>();
            //services.AddScoped<GetMeToMyMechanic.Lib.Declaration.ILocationInformationService, GetMeToMyMechanic.Lib.Definition.LocationInformationService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            
            
        }
    }
}
