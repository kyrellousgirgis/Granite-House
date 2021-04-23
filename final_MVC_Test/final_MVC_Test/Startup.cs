using final_MVC_Test.Data;
using final_MVC_Test.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test
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
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));
			services.AddDatabaseDeveloperPageExceptionFilter();

			services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {

				options.SignIn.RequireConfirmedAccount = true;
				options.Password.RequireUppercase = true;
				options.Password.RequireLowercase = true;

			}

			)	
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultUI().AddDefaultTokenProviders();
			services.AddControllersWithViews();

			services.AddDistributedMemoryCache();

			services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(30);
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});

			services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));
			services.AddScoped<IProductTypeRepoService, ProductTypeRepoService>();

			services.AddCors(options =>
				options.AddPolicy("AllowAllOrigins",
					builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
					)
			);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			StripeConfiguration.ApiKey = (Configuration.GetSection("Stripe")["SecretKey"]);
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Views/Shared/Error");

				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}



			app.UseHttpsRedirection();
			app.UseCors("AllowAllOrigins");
			app.UseStaticFiles();

			app.UseRouting();
			
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseSession();


			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute("areaRoute", "{area:Customer}/{controller=Home}/{action=Index}/{id?}");
			//	routes.MapRoute(
			//		name: "default",
			//		template: "{controller=Home}/{action=Index}/{id?}");
			//});
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllerRoute(
			//		name: "default",
			//		pattern: "{controller=Home}/{action=Index}/{id?}");
			//	endpoints.MapRazorPages();
			//});
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapAreaControllerRoute(
				  name: "areas",
				  areaName: "Customer",
				  pattern: "Customer/{controller=ClientHome}/{action=Index}/{id?}"

				);
				endpoints.MapAreaControllerRoute(
				  name: "default",
				  areaName: "Admin",
				  pattern: "Admin/{controller=AdminHome}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

                endpoints.MapFallbackToController(
                    action: "NotFound404",
                    controller: "Error"
                    );


            });

		}
	}
}
