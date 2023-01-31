using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows;

namespace Tahook.User
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ILogger<App> _logger;

        public IHost Host { get; }

        public App()
        {
            Host = new HostBuilder()
                 .ConfigureAppConfiguration((hostingContext, configurationBuilder) =>
                 {
                     configurationBuilder.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                     configurationBuilder.AddJsonFile("appsettings.json", optional: false);
                 })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainWindow>();

                    
                })
            .UseSerilog((ctx, lc) => lc.WriteTo.Debug()
                .Enrich.WithThreadId()
                .Enrich.WithCorrelationId()
                .Enrich.WithThreadName()
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Version", "1.0.0")
                .ReadFrom.Configuration(ctx.Configuration))
            .ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddSerilog();
            })
            .Build();

            _logger = Host.Services.GetRequiredService<ILogger<App>>();
            _logger.LogInformation("Host created and WPF application started.");

            
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            _logger?.LogError($"Caught top level exception {e.Exception.Message}");
            MessageBox.Show(e.Exception.Message);
            e.Handled = true; // required: otherwise exception is still thrown
        }

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            _logger?.LogDebug($"Starting application host and launching main window");

            await Host.StartAsync();

            var mainWindow = Host.Services.GetService<MainWindow>();

            mainWindow?.Show();
        }

        private async void Application_Exit(object sender, ExitEventArgs e)
        {
            _logger?.LogDebug($"Starting application host");

            using (Host)
            {
                await Host.StopAsync(TimeSpan.FromSeconds(5));
            }
        }
    }
}
