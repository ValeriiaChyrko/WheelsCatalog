using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations;

public class CarConfigurations : IEntityTypeConfiguration<CarEntityModel>
{
    public void Configure(EntityTypeBuilder<CarEntityModel> builder)
    {
        builder
            .HasOne(c => c.Color)
            .WithMany()
            .HasForeignKey(c => c.ColorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(c => c.Brand)
            .WithMany()
            .HasForeignKey(c => c.BrandId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(c => c.Model)
            .WithMany()
            .HasForeignKey(c => c.ModelId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(c => c.Photos)
            .WithOne(p => p.Car)
            .HasForeignKey(p => p.CarId);
        
        builder
            .HasMany(c => c.PriceHistories)
            .WithOne(p => p.Car)
            .HasForeignKey(c => c.CarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}