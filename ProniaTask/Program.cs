using Microsoft.EntityFrameworkCore;
using ProniaTask.Data.DAL;
using System;

namespace ProniaTask
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("Server=HOME\\SQLEXPRESS; Database= WebData; Trusted_Connection=true; Integrated Security=true; TrustServerCertificate=true;"));
			});
					

			var app = builder.Build();

			

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
