using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class PriceHistoryDataSeed
{
    internal static List<PriceHistoryEntityModel> SeedPriceHistories(List<CurrencyEntityModel> currencies,
        List<CarEntityModel> cars)
    {
        var random = new Random();
        var histories = new List<PriceHistoryEntityModel>();

        foreach (var car in cars)
        {
            var numHistories = random.Next(0, 5);

            for (var i = 0; i < numHistories; i++)
            {
                var price = random.Next(10, 1000);
                var startDate = DateTime.UtcNow.AddDays(-random.Next(1, 365));
                var createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 30));
                var updateDateTime = createDateTime.AddHours(random.Next(1, 24));

                var randomCurrency = currencies.ElementAt(random.Next(0, currencies.Count()));

                histories.Add(new PriceHistoryEntityModel
                {
                    Id = Guid.NewGuid(),
                    Price = price,
                    StartDate = startDate,
                    CurrencyId = randomCurrency.Id,
                    CarId = car.Id,
                    CreateDateTime = createDateTime,
                    UpdateDateTime = updateDateTime
                });
            }
        }

        return histories;
    }
}