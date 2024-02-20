using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Application.contracts.infrastructure.file;
using WheelsCatalog.Infrastructure.file;

namespace WheelsCatalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<ILocalFileStorage, LocalFileStorage>();
        services.AddScoped<ICloudFileStorage, CloudFileStorage>();

        return services;
    }
}