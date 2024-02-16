using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class CurrencyEntityDataSeed
{
    public static List<CurrencyEntity> SeedCurrencies()
    {
        var currencies = new List<CurrencyEntity>
        {
            CurrencyEntity.Create("USD"),
            CurrencyEntity.Create("EUR"),
            CurrencyEntity.Create("GBP"),
            CurrencyEntity.Create("JPY"),
            CurrencyEntity.Create("AUD"),
            CurrencyEntity.Create("CAD"),
            CurrencyEntity.Create("CHF"),
            CurrencyEntity.Create("CNY"),
            CurrencyEntity.Create("SEK"),
            CurrencyEntity.Create("NZD")
        };

        return currencies;
    }
}