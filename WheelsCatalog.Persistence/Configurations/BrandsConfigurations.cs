using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
namespace WheelsCatalog.Persistence.Configurations;

public class BrandsConfigurations : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        ConfigureBrandsTable(builder);
    }
    
    private static void ConfigureBrandsTable(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BrandId.Create(value)
            );

        builder.Property(c => c.Name);
        
        builder.Property(c => c.Description).HasMaxLength(512).IsRequired(false);
        
        builder.Property(c => c.LogoUrl).HasMaxLength(512).IsRequired(false);
    }
}