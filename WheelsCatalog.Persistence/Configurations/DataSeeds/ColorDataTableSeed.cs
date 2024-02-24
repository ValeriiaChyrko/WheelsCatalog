using WheelsCatalog.Persistence.Models;

namespace WheelsCatalog.Persistence.Configurations.DataSeeds;

public static class ColorDataTableSeed
{
    internal static List<ColorEntityModel> SeedColors()
    {
        var colors = new List<ColorEntityModel>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Red",
                HexCode = "#FF0000"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Green",
                HexCode = "#00FF00"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Blue",
                HexCode = "#0000FF"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Yellow",
                HexCode = "#FFFF00"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Orange",
                HexCode = "#FFA500"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Purple",
                HexCode = "#800080"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Pink",
                HexCode = "#FFC0CB"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "White",
                HexCode = "#FFFFFF"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Black",
                HexCode = "#000000"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Gray",
                HexCode = "#808080"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Brown",
                HexCode = "#A52A2A"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Cyan",
                HexCode = "#00FFFF"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Magenta",
                HexCode = "#FF00FF"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Lime",
                HexCode = "#00FF00"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Teal",
                HexCode = "#008080"
            }
        };

        return colors;
    }
}