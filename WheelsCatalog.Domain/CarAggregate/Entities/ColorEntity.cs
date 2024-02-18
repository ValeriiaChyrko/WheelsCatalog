using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.Entities;

public sealed class ColorEntity : Entity<ColorId>
{
    public string Name { get; private set; }
    public string HexCode { get; private set; }

    private ColorEntity(ColorId id, string name, string hexCode) : base(id)
    {
        Name = name;
        HexCode = hexCode;
    }

    public static ColorEntity Create(string name, string hexCode)
    {
        return new ColorEntity(ColorId.CreateUnique(), name, hexCode);
    }
    
    public void Update(string name, string hexCode)
    {
        Name = name;
        HexCode = hexCode;
    }

#pragma warning disable CS8618 
    public ColorEntity() { }
#pragma warning restore CS8618 

}
