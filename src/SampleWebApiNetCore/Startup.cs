using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SampleWebApiNetCore.Models;
using Microsoft.EntityFrameworkCore;
using SampleWebApiNetCore.Repositories;

namespace SampleWebApiNetCore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddJsonFile("dbsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"dbsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Get connectionString from dbsettings.json
            string connection = Configuration.GetConnectionString("DefaultConnection");
            // Add DataBaseContext like application service
            services.AddDbContext<DataBaseContext>(options =>
                options.UseNpgsql(connection));
            // Add Repositories
            services.AddSingleton<IWellRepository, WellRepository>();
            // Make lowercase routes URL
            services.AddRouting(routeOptions => routeOptions.LowercaseUrls = true);
            // Add framework services
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
