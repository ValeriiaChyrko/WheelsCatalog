using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class CarConfigurations : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        ConfigureCarsTable(builder);
        ConfigureCarPhotosTable(builder);
    }

    private static void ConfigureCarPhotosTable(EntityTypeBuilder<Car> builder)
    {
        builder.OwnsMany(c => c.CarPhotoIds, sb =>
            {
                sb.ToTable("CarPhotos");

                sb.HasKey(nameof(CarPhotoEntity.Id));
                sb.WithOwner().HasForeignKey("CarId");

                sb.Property(s => s.Value)
                    .HasColumnName(nameof(CarPhotoEntity.Id))
                    .ValueGeneratedNever();
            }
        );

        builder.Metadata.FindNavigation(nameof(Car.CarPhotoIds))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private static void ConfigureCarsTable(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CarId.Create(value)
            );

        builder.Property(c => c.EngineVolume);
        
        builder.Property(c => c.Description).HasMaxLength(512).IsRequired(false);
        
        builder.Property(c => c.BrandId);
        builder.Property(c => c.BrandId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BrandId.Create(value)
            );
        
        builder.Property(c => c.ModelId);
        builder.Property(c => c.ModelId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ModelId.Create(value)
            );
        
        builder.Property(c => c.ColorId);
        builder.Property(c => c.ColorId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ColorId.Create(value)
            );
    }
}