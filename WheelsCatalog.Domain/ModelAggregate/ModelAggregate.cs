using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.Model.ValueObjects;

namespace WheelsCatalog.Domain.Model;

public sealed class ModelAggregate : AggregateRoot<ModelId>
{
    public string Name { get; } 
    public string? Description { get; }
    public DateTime CreateDateTime { get; }
    public DateTime UpdateDateTime { get; }

    private ModelAggregate(ModelId id, string name, string? description, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Name = name;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static ModelAggregate Create(string name, string? description, DateTime createDateTime, DateTime updateDateTime)
    {
        return new ModelAggregate(ModelId.CreateUnique(), name, description, createDateTime, updateDateTime);
    }
}