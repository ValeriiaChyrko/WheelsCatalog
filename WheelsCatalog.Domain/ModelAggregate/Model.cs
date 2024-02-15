using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.ModelAggregate;

public sealed class Model : AggregateRoot<ModelId>
{
    public string Name { get; private set; } 
    public string? Description { get; private set; }
    public BrandId BrandId { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }
    
    
    private readonly List<Car>? _cars = new();
    public IReadOnlyCollection<Car>? Cars => _cars.AsReadOnly();

    private Model(ModelId id, string name, string? description, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Name = name;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Model Create(string name, string? description, DateTime createDateTime, DateTime updateDateTime)
    {
        return new Model(ModelId.CreateUnique(), name, description, createDateTime, updateDateTime);
    }
    
#pragma warning disable CS8618 
    private Model() { }
#pragma warning restore CS8618
}