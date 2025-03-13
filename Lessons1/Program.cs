using System.Threading.Tasks;
using Lessons1.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
       


        IConfigurationBuilder configBuilder = new ConfigurationBuilder()
            .SetBasePath(builder.Environment.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        IConfiguration configuration = configBuilder.Build();
        AppConfig appConfig = configuration.GetSection("Project").Get<AppConfig>()!;


         builder.Services.AddControllersWithViews();

        WebApplication app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

        await app.RunAsync();
    }
}