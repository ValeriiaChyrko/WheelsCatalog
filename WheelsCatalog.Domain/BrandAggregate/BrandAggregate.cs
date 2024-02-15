using WheelsCatalog.Domain.Brand.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.Brand;

public sealed class BrandAggregate : AggregateRoot<BrandId>
{
    public string Name { get; }
    public string LogoUrl { get; } 
    public string? Description { get; } 
    public DateTime CreateDateTime { get; }
    public DateTime UpdateDateTime { get; }
    
    private readonly List<Model.ModelAggregate> _models = new();
    public IReadOnlyCollection<Model.ModelAggregate> Models => _models.AsReadOnly();

    public BrandAggregate(BrandId id, string name, string logoUrl, string? description, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static BrandAggregate Create(string name, string logoUrl, string? description, DateTime createDateTime, DateTime updateDateTime)
    {
        return new BrandAggregate(BrandId.CreateUnique(), name, logoUrl, description, createDateTime, updateDateTime);
    }
}