using WheelsCatalog.Domain.CarAggregate.Entities;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class ColorEntityDataSeed
{
    public static List<ColorEntity> SeedColors()
    {
        var colors = new List<ColorEntity>
        {
            ColorEntity.Create("Red", "#FF0000"),
            ColorEntity.Create("Blue", "#0000FF"),
            ColorEntity.Create("Green", "#00FF00"),
            ColorEntity.Create("Yellow", "#FFFF00"),
            ColorEntity.Create("Black", "#000000"),
            ColorEntity.Create("White", "#FFFFFF"),
            ColorEntity.Create("Silver", "#C0C0C0"),
            ColorEntity.Create("Gray", "#808080"),
            ColorEntity.Create("Brown", "#A52A2A"),
            ColorEntity.Create("Orange", "#FFA500")
        };

        return colors;
    }
}