using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.ColorAggregate;

public sealed class Color : AggregateRoot<ColorId>
{
    public string Name { get; private set; }
    public string HexCode { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private Color(ColorId id, string name, string hexCode, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Name = name;
        HexCode = hexCode;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }

    public static Color Create(string name, string hexCode)
    {
        var recordDateTime = DateTime.Now;
        
        return new Color(ColorId.CreateUnique(), name, hexCode, recordDateTime, recordDateTime);
    }
    
    public void Update(string name, string hexCode)
    {
        Name = name;
        HexCode = hexCode;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618 
    public Color() { }
#pragma warning restore CS8618 

}
