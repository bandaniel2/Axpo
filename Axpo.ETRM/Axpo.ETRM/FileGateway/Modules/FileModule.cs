namespace Axpo.ETRM.FileGateway.Modules;

using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces;

public static class FileModule
{
    public static IServiceCollection RegisterFileGateway(this IServiceCollection services, FileConfiguration config)
    {
        services.AddSingleton<IFileGateway>(new FileGateway(config.FolderPath));

        return services;
    }
}