using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
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
    
    private readonly List<CarId> _carIds = new();
    public IReadOnlyCollection<CarId> CarIds => _carIds.AsReadOnly();

    private Model(ModelId id, string name, string? description, DateTime createDateTime, DateTime updateDateTime, BrandId brandId) : base(id)
    {
        Name = name;
        Description = description;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
        BrandId = brandId;
    }
    
    public void AddCarId(CarId carId)
    {
        _carIds.Add(carId);
    }
    
    public static Model Create(string name, string? description, BrandId brandId)
    {
        var modelId = ModelId.CreateUnique();
        var recordDateTime = DateTime.Now;
        return new Model(modelId, name, description, recordDateTime, recordDateTime, brandId);
    }
    
    public void Update(string name, string? description, BrandId brandId)
    {
        Name = name;
        Description = description;
        BrandId = brandId;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618
    public Model() { }
#pragma warning restore CS8618 

}