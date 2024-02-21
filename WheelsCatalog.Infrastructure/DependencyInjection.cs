using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Application.contracts.infrastructure.file;
using WheelsCatalog.Infrastructure.file;

namespace WheelsCatalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddTransient<IFileService, FileService>();
        services.AddTransient<ILocalFileStorage, LocalFileStorage>();
        services.AddTransient<ICloudFileStorage, CloudFileStorage>();

        return services;
    }
}