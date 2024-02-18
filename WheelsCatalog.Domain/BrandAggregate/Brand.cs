using WheelsCatalog.Domain.BrandAggregate.Events;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.BrandAggregate;

public sealed class Brand : AggregateRoot<BrandId>
{
    public string Name { get; private set; }
    public string LogoUrl { get; private set; }
    public string? Description { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private readonly List<ModelId> _modelIds = new();
    public IReadOnlyCollection<ModelId> ModelIds => _modelIds.AsReadOnly();

    private Brand(BrandId id, string name, string logoUrl, string? description, DateTime createDateTime,
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
    
    public static Brand Create(string name, string logoUrl, string? description)
    {
        var brandId = BrandId.CreateUnique();
        var recordDateTime = DateTime.Now;
        var brand = new Brand(brandId, name, logoUrl, description, recordDateTime, recordDateTime);

        brand.AddDomainEvent(new BrandCreated(brand));
        return brand;
    }
    
    public void Update(string name, string logoUrl, string? description)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        UpdateDateTime = DateTime.Now;

        AddDomainEvent(new BrandUpdated(this));
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Brand()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
}