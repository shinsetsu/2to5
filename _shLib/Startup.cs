using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Westwind.AspNetCore.LiveReload;

namespace _shLib
{
	public class Startup
	{
		public Startup(IConfiguration configuration) { Configuration = configuration; }

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// ■■■■■■■■■■■■■■■■■■■■■■
			//Simplicity?   edit to define root in this way again....
			//// ■■■■■■■■■■■■■■■■■■■■■■
			//string physicalWebRootPath = Server.MapPath("~/");
			//
			//return Content(physicalWebRootPath);
			// ■■■■■■■■■■■■■■■■■■■■■■

			//services.AddLiveReload(config =>
			//{
			//	// optional - use config instead
			//	//config.LiveReloadEnabled = true;
			//	//config.FolderToMonitor = Path.GetFullname(Path.Combine(Env.ContentRootPath,"..")) ;
			//});

			//services.AddRazorPages().AddRazorPagesOptions(options => { options.RootDirectory = "/"; });
			services.AddRazorPages();
			//services.AddMvc().AddRazorPagesOptions(options =>
			//{
			//	//just to respect Microsoft way, it is better to have Pages folder
			//	//to contains your folders.
			//	options.RootDirectory = "/";
			//});

			//services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/");


			//WebHost = Configuration["WebRoot"];
			//if (string.IsNullOrEmpty(WebRoot))
			//	WebRoot = Environment.CurrentDirectory;

			//var razEnabled = Configuration["RazorEnabled"];
			//UseRazor = string.IsNullOrEmpty(razEnabled) ||
			//	     !razEnabled.Equals("false", StringComparison.InvariantCultureIgnoreCase);


			// alt+254 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
			// alt+254 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
			//#if USE_RAZORPAGES
			//if (UseRazor)
			//{
			//services.AddRazorPages(opt => { opt.RootDirectory = "/"; })
			//.AddRazorRuntimeCompilation(
			//opt =>
			//{
			//// This would be useful but it's READ-ONLY
			//// opt.AdditionalReferencePaths = Path.Combine(WebRoot,"bin");
			//opt.FileProviders.Add(new PhysicalFileProvider(WebRoot));
			//});
			//}
			//#endif
			// alt+254 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
			// alt+254 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
		}
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				//app.UseDeveloperExceptionPage();
				//app.UseDatabaseErrorPage();
				//app.UseLiveReload();  //Install-Package WestWind.AspnetCore.LiveReload      ---  This only Require Dotnet.watch.run
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}


			//■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
			//■■■■■■■■■■■■  ADded from a reference, not changed or used yet... Calling
			// Processing in the Chain of server here..  see below.....
			//	- 
			//■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
			//■■■■■■■■■■//app.Run(async (context) =>
			//■■■■■■■■■■//{
			//■■■■■■■■■■//	await context.Response.WriteAsync("worker_Process_Name : "
			//■■■■■■■■■■//		+ System.Diagnostics.Process.GetCurrentProcess().ProcessName);

			//};
			//■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■



			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
			});
		}
	}
}
