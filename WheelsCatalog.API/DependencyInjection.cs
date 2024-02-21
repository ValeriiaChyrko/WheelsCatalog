using AutoMapper;
using WheelsCatalog.Application.profiles;
using WheelsCatalog.Persistence.Mappers.Profiles;

namespace WheelsCatalog.API;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddSingleton<IMapper>(_ =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddApplicationAutoMapper();
                cfg.AddPersistenceAutoMapper();
            });

            return config.CreateMapper();
        });
        
        return services;
    }
}

public static class AutoMapperConfiguration
{
    public static void AddPersistenceAutoMapper(this IMapperConfigurationExpression cfg)
    {
        cfg.AddProfile(new BrandEntityModelMappingProfile());
        cfg.AddProfile(new CarEntityModelMappingProfile());
        cfg.AddProfile(new CarPhotoEntityModelMappingProfile());
        cfg.AddProfile(new ColorEntityModelMappingProfile());
        cfg.AddProfile(new CurrencyEntityModelMappingProfile());
        cfg.AddProfile(new ModelEntityModelMappingProfile());
        cfg.AddProfile(new PriceHistoryEntityModelMappingProfile());
    }
    
    public static void AddApplicationAutoMapper(this IMapperConfigurationExpression cfg)
    {
        cfg.AddProfile(new BrandMappingProfile());
        cfg.AddProfile(new CarPhotoMappingProfile());
        cfg.AddProfile(new ModelMappingProfile());
        cfg.AddProfile(new CarMappingProfile());
        cfg.AddProfile(new PriceMappingProfile());
    }
}

