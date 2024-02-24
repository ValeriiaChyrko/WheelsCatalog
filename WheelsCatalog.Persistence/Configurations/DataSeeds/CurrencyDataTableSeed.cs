using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class CurrencyDataTableSeed
{
    internal static List<CurrencyEntityModel> SeedCurrencies()
    {
        var currencies = new List<CurrencyEntityModel>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "USD"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "EUR"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "GBP"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "JPY"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "AUD"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "CAD"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "CHF"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "CNY"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "SEK"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "NZD"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "NOK"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "ZAR"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "MXN"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "SGD"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Acronym = "HKD"
            }
        };

        return currencies;
    }
}