using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds
{
    public static class ColorDataTableSeed
    {
        internal static List<ColorEntityModel> SeedColors()
        {
            var colors = new List<ColorEntityModel>
            {
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Red",
                    HexCode = "#FF0000"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Green",
                    HexCode = "#00FF00"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Blue",
                    HexCode = "#0000FF"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Yellow",
                    HexCode = "#FFFF00"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Orange",
                    HexCode = "#FFA500"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Purple",
                    HexCode = "#800080"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Pink",
                    HexCode = "#FFC0CB"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "White",
                    HexCode = "#FFFFFF"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Black",
                    HexCode = "#000000"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Gray",
                    HexCode = "#808080"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Brown",
                    HexCode = "#A52A2A"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Cyan",
                    HexCode = "#00FFFF"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Magenta",
                    HexCode = "#FF00FF"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Lime",
                    HexCode = "#00FF00"
                },
                new ColorEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Teal",
                    HexCode = "#008080"
                }
            };

            return colors;
        }
    }
}
