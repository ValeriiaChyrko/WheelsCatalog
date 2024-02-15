using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WheelsCatalog.Persistence;

public static class DependencyInjection
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("WheelsCatalog_Local");

        services.AddDbContext<WheelsCatalogDbContext>(options =>
            options.UseSqlServer(connectionString));
    }
}