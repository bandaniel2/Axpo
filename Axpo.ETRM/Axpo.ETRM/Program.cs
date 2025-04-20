using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Axpo.ETRM.PowerServiceGateway.Modules;
using Axpo.ETRM.FileGateway.Modules;
using Axpo.ETRM.ReportService.Modules;
using Axpo.ETRM.ReportService.Interfaces;
using Axpo.ETRM;

await Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((context,services) =>
    {
        var config = new Configuration();
        context.Configuration.Bind(config);
        services.AddSingleton(config);

        services.RegisterPowerServiceGateway(); 
        services.RegisterFileGateway(config.FileGateway); 
        services.RegisterReportService();

        services.AddHostedService<ReportScheduler>();
    })
    .Build()
    .RunAsync();