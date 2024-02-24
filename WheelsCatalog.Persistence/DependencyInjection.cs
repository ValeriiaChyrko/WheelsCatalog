using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Repositories;

namespace WheelsCatalog.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WheelsCatalog_Local");

        services.AddDbContext<WheelsCatalogDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<PublishDomainEventsInterceptor>();

        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ICarPhotoRepository, CarPhotoRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IPriceHistoryRepository, PriceHistoryRepository>();

        return services;
    }
}