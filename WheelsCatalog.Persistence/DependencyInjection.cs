using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Profiles;

namespace WheelsCatalog.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WheelsCatalog_Local");

        services.AddDbContext<WheelsCatalogDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<PublishDomainEventsInterceptor>();
        
        services.AddScoped(_ =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BrandMappingProfile()); 
                cfg.AddProfile(new ModelMappingProfile()); 
                cfg.AddProfile(new ColorEntityMappingProfile()); 
                cfg.AddProfile(new CarMappingProfile()); 
                cfg.AddProfile(new PriceHistoryMappingProfile()); 
                cfg.AddProfile(new CurrencyMappingProfile()); 
                cfg.AddProfile(new CarPhotoEntityMappingProfile()); 
            });

            return config.CreateMapper();
        });

        return services;
    }
}