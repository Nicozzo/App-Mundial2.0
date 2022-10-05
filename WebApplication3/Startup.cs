using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicaNegocio.InterfacesRepositorios;
using LogicaAccesoDatos.BaseDatos;
using LogicaAplicacion.InterfacesCU;
using LogicaAplicacion.CasosUso;
using Microsoft.EntityFrameworkCore;


namespace WebApplication3
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
            services.AddControllersWithViews();
            services.AddMvc();

            services.AddSession();

            services.AddScoped<IAltaPais, AltaPais>();
            services.AddScoped<IBuscarID, BuscarID>();
            services.AddScoped<IListadoRegion, ListadoRegiones>();

            services.AddScoped<IRepositorioPaises, RepositorioPaises>();
            services.AddScoped<IRepositorioRegion, RepositorioRegion>();

            services.AddScoped<IListadoPais, ListadoPais>();
            services.AddScoped<IActualizarPais, ActualizarPais>();

            string strCon = Configuration.GetConnectionString("MiConexion");
            services.AddDbContextPool<LibreriaContext>(options => options.UseSqlServer(strCon));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Paises}/{action=index}/{ id ?}");
            });
        }
    }
}
