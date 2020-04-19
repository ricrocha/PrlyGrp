using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using PrlyGrp.CountryCatalog.ApplicationCore.Interfaces;
using PrlyGrp.CountryCatalog.Infrastructure.Data;
using Serilog;

namespace PrlyGrp.CountryCatalog.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            ConfigureServices(services);
        }

        public void ConfigureProductionServices(IServiceCollection services)
        {
            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CountryCatalogDbContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("CountryCatalogConnection")));
            //services.AddApplicationInsightsTelemetry();
            services.AddControllers();

            //var container = new ContainerBuilder();
            //container.Populate(services);
            //return new AutofacServiceProvider(container.Build());
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //configure auto fac here          
            //...
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IAsyncRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseSerilogRequestLogging();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}