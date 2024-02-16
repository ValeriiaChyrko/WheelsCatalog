using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class CarPhotosConfiguration: IEntityTypeConfiguration<CarPhotoEntity>
{
    public void Configure(EntityTypeBuilder<CarPhotoEntity> builder)
    {
        ConfigureCarPhotosTable(builder);
    }

    private static void ConfigureCarPhotosTable(EntityTypeBuilder<CarPhotoEntity> builder)
    {
        builder.ToTable("CarPhotos");
        
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CarPhotoId.Create(value)
            );

        builder.Property(c => c.PhotoUrl).HasMaxLength(512);
    }
}