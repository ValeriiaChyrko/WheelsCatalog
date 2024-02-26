using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations;

internal class ModelConfigurations : IEntityTypeConfiguration<ModelEntityModel>
{
    public void Configure(EntityTypeBuilder<ModelEntityModel> builder)
    {
        builder
            .HasOne(m => m.Brand)
            .WithMany(b => b.Models)
            .HasForeignKey(m => m.BrandId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasMany(m => m.Cars)
            .WithOne(c => c.Model)
            .HasForeignKey(c => c.ModelId) 
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(b => b.Name).IsUnique();
    }
}