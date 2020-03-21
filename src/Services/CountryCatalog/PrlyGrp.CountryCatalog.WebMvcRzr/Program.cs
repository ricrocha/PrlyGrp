using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;

namespace PrlyGrp.CountryCatalog.WebMvcRzr
{
    public class Program
    {
        public static readonly string Namespace = typeof(Program).Namespace;
        public static readonly string AppName = Namespace.Substring(Namespace.LastIndexOf('.', Namespace.LastIndexOf('.') - 1) + 1);

        public static int Main(string[] args)
        {
            var configuration = GetConfiguration();
            Log.Logger = CreateSerilogLogger(configuration); 

            try
            {
                Log.Information("Configuring web host ({ApplicationContext})...", AppName);
                var host = CreateHostBuilder(configuration, args).Build();
                Log.Information("Starting web host({ApplicationContext})...", AppName);
                host.Run();
                return 0;

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})...", AppName);
                //throw ex;
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(IConfiguration configuration, string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseConfiguration(configuration);
                    webBuilder.CaptureStartupErrors(false);
                    //webBuilder.ConfigureKestrel(options =>
                    //{
                    //    var ports = GetDefinedPorts(configuration);
                    //    options.Listen(IPAddress.Any, ports.httpPort, listenOptions =>
                    //    {
                    //        listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
                    //    });
                    //    options.Listen(IPAddress.Any, ports.grpcPort, listenOptions =>
                    //    {
                    //        listenOptions.Protocols = HttpProtocols.Http2;
                    //    });
                    //});
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                });
        }

        private static ILogger CreateSerilogLogger(IConfiguration configuration)
        {
            return new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public static (int httpPort, int grcpPort) GetDefinedPorts(IConfiguration configuration)
        {
            var grpcPort = configuration.GetValue("GRPC_PORT", 81);
            var port = configuration.GetValue("PORT", 80);
            return (port, grpcPort);
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            var configuration = builder.Build();
            if (configuration.GetValue<bool>("UseVault", false))
            {
                builder.AddAzureKeyVault(
                    $"https://{configuration["Vault:Name"]}.vault.azure.net/",
                    configuration["Vault:ClientId"],
                    configuration["Vault:ClientSecret"]);
            }
            return builder.Build();
        }
    }
}
