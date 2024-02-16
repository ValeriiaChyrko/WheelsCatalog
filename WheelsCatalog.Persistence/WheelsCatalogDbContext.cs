using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Persistence;

public class WheelsCatalogDbContext : DbContext
{
    public WheelsCatalogDbContext(DbContextOptions<WheelsCatalogDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WheelsCatalogDbContext).Assembly);
    }

    //public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<Model> Models { get; set; } = null!;
}