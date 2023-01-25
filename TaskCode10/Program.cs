using Microsoft.EntityFrameworkCore;
using TaskCode10.DAL;

namespace TaskCode10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")));
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(name: "areas",pattern: "{area:exists}/{controller=Employee}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Pozition}/{action=Index}/{id?}");
            app.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");
            app.Run();
        }
    }
}