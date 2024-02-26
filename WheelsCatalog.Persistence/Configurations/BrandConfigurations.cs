using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations;

internal class BrandConfigurations : IEntityTypeConfiguration<BrandEntityModel>
{
    public void Configure(EntityTypeBuilder<BrandEntityModel> builder)
    {
        builder
            .HasMany(b => b.Models)
            .WithOne(m => m.Brand)
            .HasForeignKey(m => m.BrandId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(b => b.Name).IsUnique();
        builder.HasIndex(b => b.LogoUrl).IsUnique();
    }
}