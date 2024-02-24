using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class ModelDataSeed
{
    internal static List<ModelEntityModel> SeedModels(List<BrandEntityModel> brands)
    {
        var models = new List<ModelEntityModel>();

        var random = new Random();

        foreach (var brand in brands)
            for (var i = 0; i < 3; i++)
            {
                var modelName = $"Model{i + 1} for {brand.Name}";
                var modelDescription = $"Description for {modelName}";

                var createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 365));
                var updateDateTime = createDateTime.AddDays(random.Next(1, 365));

                var model = new ModelEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = modelName,
                    Description = modelDescription,
                    CreateDateTime = createDateTime,
                    UpdateDateTime = updateDateTime,
                    BrandId = brand.Id
                };
                models.Add(model);
            }

        return models;
    }
}