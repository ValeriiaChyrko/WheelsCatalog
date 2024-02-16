using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class ColorsConfigurations : IEntityTypeConfiguration<ColorEntity>
{
    public void Configure(EntityTypeBuilder<ColorEntity> builder)
    {
        ConfigureModelsTable(builder);
    }

    private static void ConfigureModelsTable(EntityTypeBuilder<ColorEntity> builder)
    {
        builder.ToTable("Colors");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ColorId.Create(value)
            );

        builder.Property(c => c.Name).HasMaxLength(255);
        
        builder.Property(c => c.HexCode).HasMaxLength(127).IsRequired(false);
        
        builder.HasMany<Car>()
            .WithOne()
            .HasForeignKey(ph => ph.ColorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}