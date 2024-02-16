using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class PriceHistoryDataSeed
{
    public static List<PriceHistory> SeedPriceHistories(IEnumerable<CurrencyId> currencyIds)
    {
        var random = new Random();

        return (from currencyId in currencyIds 
            let price = random.Next(10, 1000) 
            let startDate = DateTime.UtcNow.AddDays(-random.Next(1, 365)) 
            let createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 30)) 
            let updateDateTime = createDateTime.AddHours(random.Next(1, 24)) 
            select PriceHistory.Create(price, startDate, currencyId, createDateTime, updateDateTime)).ToList();
    }
}