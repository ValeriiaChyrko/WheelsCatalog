using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations;

public class PriceHistoryConfigurations : IEntityTypeConfiguration<PriceHistory>
{
    public void Configure(EntityTypeBuilder<PriceHistory> builder)
    {
        ConfigurePriceHistoriesTable(builder);
    }

    private static void ConfigurePriceHistoriesTable(EntityTypeBuilder<PriceHistory> builder)
    {
        builder.ToTable("PriceHistories");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => PriceHistoryId.Create(value)
            );

        builder.Property(c => c.Price);
        builder.Property(c => c.StartDate);
        builder.Property(c => c.CurrencyId)
            .HasConversion(
                id => id.Value,
                value => CurrencyId.Create(value)
            );

        builder.HasOne<CurrencyEntity>()
            .WithMany()
            .HasForeignKey(ph => ph.CurrencyId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}