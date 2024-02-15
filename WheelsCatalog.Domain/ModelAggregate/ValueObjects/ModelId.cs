using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.ModelAggregate.ValueObjects;

public class ModelId : ValueObject
{
    public Guid Value { get; }

    private ModelId(Guid value)
    {
        Value = value;
    }
    
    public static ModelId Create(Guid value)
    {
        return new ModelId(value);
    }

    public static ModelId CreateUnique()
    {
        return new ModelId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
#pragma warning disable CS8618 
    private ModelId() { }
#pragma warning restore CS8618
}