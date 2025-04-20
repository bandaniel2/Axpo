namespace Axpo.ETRM.PowerServiceGateway.Modules;

using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces;

public static class PowerServiceModule
{
    public static IServiceCollection RegisterPowerServiceGateway(this IServiceCollection services)
    {
        services.AddSingleton<IPowerService, PowerService>();
        services.AddSingleton<IPowerServiceGateway, PowerServiceGateway>();

        return services;
    }
}