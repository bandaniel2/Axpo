namespace Axpo.ETRM.ReportService.Modules;

using Microsoft.Extensions.DependencyInjection;
using Interfaces;

public static class ServiceModule
{
    public static IServiceCollection RegisterReportService(this IServiceCollection services)
    {
        services.AddSingleton<IReportService, ReportService>();

        return services;
    }
}