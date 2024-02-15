using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate;

namespace WheelsCatalog.Domain.BrandAggregate;

public sealed class Brand : AggregateRoot<BrandId>
{
    public string Name { get; private set; }
    public string LogoUrl { get; private set; }
    public string? Description { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private readonly List<Model> _models = new();
    public IReadOnlyCollection<Model> Models => _models.AsReadOnly();
    private readonly List<Car>? _cars = new();
    public IReadOnlyCollection<Car>? Cars => _cars.AsReadOnly();


    public Brand(BrandId id, string name, string logoUrl, string? description, DateTime createDateTime,
        DateTime updateDateTime) : base(id)
    {
        Name = name;
        LogoUrl = logoUrl;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }

    public static Brand Create(string name, string logoUrl, string? description, DateTime createDateTime,
        DateTime updateDateTime)
    {
        return new Brand(BrandId.CreateUnique(), name, logoUrl, description, createDateTime, updateDateTime);
    }

#pragma warning disable CS8618 
    private Brand() { }
#pragma warning restore CS8618
}