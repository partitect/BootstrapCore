using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DBApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Dependency Injection : Baðýmlýlýklarý azaltma
            services.AddSingleton<IData, MSSqlData>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else app.UseStatusCodePagesWithReExecute("/Error", "?statusCode={0}");

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
