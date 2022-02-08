using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using PracticalTask.Services.Implementations;

namespace PracticalTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileService.ReadFactsFromFile();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
