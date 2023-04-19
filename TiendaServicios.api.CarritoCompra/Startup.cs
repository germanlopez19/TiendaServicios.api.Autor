using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicios.api.CarritoCompra.Aplicaion;
using TiendaServicios.api.CarritoCompra.Persistensia;
using TiendaServicios.api.CarritoCompra.RemoteInterface;
using TiendaServicios.api.CarritoCompra.RemoteServices;

namespace TiendaServicios.api.CarritoCompra
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
            services.AddScoped<ILibrosServices, LibrosService>();
            services.AddControllers();
            services.AddDbContext<CarritoContexto>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("conexionDB"));
            });
            //var connectionMySqlString = Configuration.GetConnectionString("ConexionDatabase");

            //services.AddDbContext<CarritoContexto>(options => {

            //    options.UseMySql(connectionMySqlString);

            //});
            services.AddMediatR(typeof(Nuevo.Manejador).Assembly);
            services.AddHttpClient("Libros", config =>
            {
                config.BaseAddress = new Uri(Configuration["Services:Libros"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
