using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class CarConfigurations : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        ConfigureCarsTable(builder);
        ConfigureCarPhotosTable(builder);
        ConfigurePriceHistoryTable(builder);
    }

    private static void ConfigurePriceHistoryTable(EntityTypeBuilder<Car> builder)
    {
        builder.OwnsMany(c => c.PriceHistories, sb =>
        {
            sb.ToTable("PriceHistory");

            sb.HasKey(  nameof(PriceHistory.Id));
            sb.WithOwner().HasForeignKey("CarId");
            
            sb.Property(s=>s.Id)
                .HasColumnName(nameof(PriceHistory.Id))
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => PriceHistoryId.Create(value)
                );

            sb.Property(c => c.Price);
            sb.Property(c => c.StartDate);
            
            sb.Property(c => c.CurrencyId);
            sb.Property(c => c.CurrencyId)
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => CurrencyId.Create(value)
                );
            
            sb.HasOne<CurrencyEntity>()
                .WithMany()
                .HasForeignKey(ph => ph.CurrencyId);
        });
        
        builder.Metadata.FindNavigation(nameof(Car.PriceHistories))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private static void ConfigureCarPhotosTable(EntityTypeBuilder<Car> builder)
    {
        builder.OwnsMany(c => c.Photos, sb =>
            {
                sb.ToTable("CarPhotos");

                sb.HasKey(nameof(CarPhotoEntity.Id));
                sb.WithOwner().HasForeignKey("CarId"); 
            
                sb.Property(s=>s.Id)
                    .HasColumnName(nameof(CarPhotoEntity.Id))
                    .ValueGeneratedNever()
                    .HasConversion(
                        id => id.Value,
                        value => CarPhotoId.Create(value)
                    );
                
                sb.Property(c => c.PhotoUrl).HasMaxLength(512);
            }
        );

        builder.Metadata.FindNavigation(nameof(Car.Photos))!.SetPropertyAccessMode(PropertyAccessMode.Field);
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