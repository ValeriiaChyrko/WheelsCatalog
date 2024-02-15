using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Model.ValueObjects;

public class ModelId : ValueObject
{
    public Guid Value { get; }

    private ModelId(Guid value)
    {
        Value = value;
    }

    public static ModelId CreateUnique()
    {
        return new ModelId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}