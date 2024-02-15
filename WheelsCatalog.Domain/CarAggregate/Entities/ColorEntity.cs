using WheelsCatalog.Domain.Car.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Car.Entities;

public sealed class ColorEntity : Entity<ColorId>
{
    public string Name { get; }
    public string HexCode { get; }

    private ColorEntity(ColorId id, string name, string hexCode) : base(id)
    {
        Name = name;
        HexCode = hexCode;
    }

    public static ColorEntity Create(string name, string hexCode)
    {
        return new ColorEntity(ColorId.CreateUnique(), name, hexCode);
    }
}
