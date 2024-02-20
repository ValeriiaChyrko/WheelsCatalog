using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.BrandAggregate;

public sealed class Brand : AggregateRoot<BrandId>
{
    public string Name { get; private set; }
    public string LogoUrl { get; private set; }
    public string? Description { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private Brand(BrandId id, string name, string logoUrl, string? description, DateTime createDateTime,
        DateTime updateDateTime) : base(id)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Brand Create(string name, string logoUrl, string? description)
    {
        var brandId = BrandId.CreateUnique();
        var recordDateTime = DateTime.Now;
        var brand = new Brand(brandId, name, logoUrl, description, recordDateTime, recordDateTime);

        return brand;
    }
    
    public void Update(string name, string logoUrl, string? description)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Brand()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
}