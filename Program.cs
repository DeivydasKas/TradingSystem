using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;
using TradingSystem.Services;

namespace TradingSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            ConfigureServices(services, configuration);


            var provider = services.BuildServiceProvider();

            var form = provider.GetRequiredService<Form1>();

            Application.Run(form);
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var baseUrl = configuration["ApiSettings:BaseUrl"];
            if(string.IsNullOrWhiteSpace(baseUrl))
                throw new Exception("ApiSettings:BaseUrl was not defined in appsettings.json");

            services.AddHttpClient("DummyJsonClient", client =>
            {
                client.BaseAddress = new Uri(baseUrl);
                client.Timeout = TimeSpan.FromSeconds(300);
            });

            services.AddTransient<ITradesService, TradesService>();
            services.AddTransient<IPositionCalculationService, PositionCalculationService>();
            services.AddTransient<Form1>();
        }
    }
}