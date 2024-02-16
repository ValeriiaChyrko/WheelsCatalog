using WheelsCatalog.Domain.BrandAggregate.Events;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.BrandAggregate;

public sealed class Brand : AggregateRoot<BrandId, Guid>
{
    public string Name { get; private set; }
    public string LogoUrl { get; private set; }
    public string? Description { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private readonly List<ModelId> _modelIds = new();
    public IReadOnlyCollection<ModelId> ModelIds => _modelIds.AsReadOnly();

    public Brand(BrandId id, string name, string logoUrl, string? description, DateTime createDateTime,
        DateTime updateDateTime) : base(id)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }

    public void AddModelId(ModelId modelId)
    {
        _modelIds.Add(modelId);
    }
    
    public static Brand Create(string name, string logoUrl, string? description, DateTime createDateTime,
        DateTime updateDateTime)
    {
        var brand = new Brand(BrandId.CreateUnique(), name, logoUrl, description, createDateTime, updateDateTime);

        brand.AddDomainEvent(new BrandCreated(brand));
        return brand;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Brand()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
}