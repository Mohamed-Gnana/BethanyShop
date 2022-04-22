using Bethany;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bethany.Models;

var builder = WebApplication.CreateBuilder(args);

Services.Run(builder.Services, builder.Configuration);
var app = builder.Build();

IHostEnvironment env = app.Environment;
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapRazorPages();
});


app.Run();


//namespace Bethany
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        private static IHostBuilder CreateHostBuilder(string[] args)
//        {
//            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<StartUp>());
//        }
//    }
//}

