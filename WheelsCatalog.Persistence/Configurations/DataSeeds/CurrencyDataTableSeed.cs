using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds
{
    public static class CurrencyDataTableSeed
    {
        internal static List<CurrencyEntityModel> SeedCurrencies()
        {
            var currencies = new List<CurrencyEntityModel>
            {
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "USD"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "EUR"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "GBP"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "JPY"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "AUD"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "CAD"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "CHF"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "CNY"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "SEK"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "NZD"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "NOK"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "ZAR"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "MXN"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "SGD"
                },
                new CurrencyEntityModel
                {
                    Id = Guid.NewGuid(),
                    Acronym = "HKD"
                }
            };

            return currencies;
        }
    }
}
