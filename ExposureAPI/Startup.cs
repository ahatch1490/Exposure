using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExposureAPI.Models;
using ExposureAPI.Resources.Client;
using ExposureAPI.Resources.GoodReads;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Npgsql;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace ExposureAPI
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
            services.AddSingleton<IContextClient, ContextClient>();     
            services.AddSingleton<IGoodReadsSettings, GoodReadsSettings>();
            services.AddSingleton<IXMLClient, XMLClient>();
            services.AddSingleton<IGoodReadsService,GoodReadsService>();
            services.AddSingleton<SiteService, SiteService>();
            services.AddSingleton<ContentSectionService, ContentSectionService>();
            services.AddSingleton(qf => {
                var str = Configuration["ConnectionString"]; //"Host=localhost;Port=5432;Username=ahatch1490;Database=exposure;"

                var connection = new NpgsqlConnection(str);

                var compiler = new PostgresCompiler();

                return new QueryFactory(connection,compiler);

            });
          


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
