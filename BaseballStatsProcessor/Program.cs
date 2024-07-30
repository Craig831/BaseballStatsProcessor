using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using BaseballStatsProcessor.Interfaces;
using BaseballStatsProcessor.MlbService;
using BaseballStatsProcessor.MlbService.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BaseballStatsProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting stats download.");
            var host = CreateHostBuilder(args).Build();
            var _mlbService = host.Services.GetService<IMlbServiceClient>();

            // fire a call to my service to get each mlb team, then iterate over them
            // and update rosters

            var brewersRoster = _mlbService.GetTeamRoster(158).Result;

            // TODO: think about how and when to transform from mlb object to my object and save
            //       how can i batch up per team?  do i need to?

            Console.Read();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                })
                .ConfigureServices((context, services) =>
                {
                    //service registrations
                    services.AddSingleton<IMlbServiceClient, MlbServiceClient>();
                });

            return hostBuilder;
        }
    }
}