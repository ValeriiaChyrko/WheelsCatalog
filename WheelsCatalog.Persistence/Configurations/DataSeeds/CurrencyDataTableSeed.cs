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
            }
        };

        return currencies;
    }
}