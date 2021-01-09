using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic
{
	public class Startup
	{

		IConfiguration configuration;
		public Startup(IConfiguration _configuration)
		{
			configuration = _configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{

			services.AddControllersWithViews();
			services.AddDbContext<MyContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConStr1")));
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
			else app.UseStatusCodePagesWithReExecute("/Error", "?sCode={0}");

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
