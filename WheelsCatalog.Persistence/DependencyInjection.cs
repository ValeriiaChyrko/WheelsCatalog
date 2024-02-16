using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Persistence.Configurations;
using WheelsCatalog.Persistence.Interceptors;

namespace WheelsCatalog.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WheelsCatalog_Local");

        services.AddDbContext<WheelsCatalogDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<PublishDomainEventsInterceptor>();

        using var serviceProvider = services.BuildServiceProvider();
        var dbContext = serviceProvider.GetRequiredService<WheelsCatalogDbContext>();
        //DatabaseInitializer.SeedData(dbContext);

        return services;
    }
}