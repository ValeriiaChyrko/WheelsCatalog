using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class ModelsConfigurations : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        ConfigureModelsTable(builder);
    }

    private static void ConfigureModelsTable(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models");
        
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ModelId.Create(value)
            );

        builder.Property(c => c.Name);
        
        builder.Property(c => c.Description).HasMaxLength(512).IsRequired(false);
        
        builder.Property(c => c.BrandId);
        builder.Property(c => c.BrandId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BrandId.Create(value)
            );
        
        builder.HasMany(b => b.Cars)
            .WithOne()
            .HasForeignKey(c => c.ModelId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}