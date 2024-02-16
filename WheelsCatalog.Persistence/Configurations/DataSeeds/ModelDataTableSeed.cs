using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class ModelDataSeed
{
    public static List<Model> SeedModels(List<Brand> brands)
    {
        var models = new List<Model>();

        var random = new Random();

        foreach (var brand in brands)
        {
            for (var i = 0; i < 3; i++)
            {
                var modelName = $"Model{i + 1} for {brand.Name}";
                var modelDescription = $"Description for {modelName}";
                
                var createDateTime = DateTime.UtcNow.AddDays(-random.Next(1, 365));
                var updateDateTime = createDateTime.AddDays(random.Next(1, 365));

                var model = Model.Create(modelName, modelDescription, createDateTime, updateDateTime, brand.Id);
                models.Add(model);
            }
        }

        return models;
    }
}