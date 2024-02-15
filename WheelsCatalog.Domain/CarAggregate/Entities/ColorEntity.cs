using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.CarAggregate.Entities;

public sealed class ColorEntity : Entity<ColorId>
{
    public string Name { get; private set; }
    public string HexCode { get; private set; }
    
    private readonly List<Car>? _cars = new();
    public IReadOnlyCollection<Car>? Cars => _cars.AsReadOnly();

    private ColorEntity(ColorId id, string name, string hexCode) : base(id)
    {
        Name = name;
        HexCode = hexCode;
    }

    public static ColorEntity Create(string name, string hexCode)
    {
        return new ColorEntity(ColorId.CreateUnique(), name, hexCode);
    }
    
#pragma warning disable CS8618 
    private ColorEntity() { }
#pragma warning restore CS8618
}
