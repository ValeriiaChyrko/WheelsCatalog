using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;

namespace WheelsCatalog.Domain.CarAggregate;

public sealed class Car : AggregateRoot<CarId>
{
    public int EngineVolume { get; private set; }
    public string? Description { get; private set; }
    public ColorId ColorId { get; private set; }
    public BrandId BrandId { get; private set; }
    public ModelId ModelId { get; private set; }

    private readonly List<CarPhotoEntity> _photos = new();
    public IReadOnlyCollection<CarPhotoEntity> Photos => _photos.AsReadOnly();
    
    private readonly List<PriceHistory> _priceHistories = new();
    public IReadOnlyCollection<PriceHistory> PriceHistories => _priceHistories.AsReadOnly();
    
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    public Car(CarId id, int engineVolume, string? description, ColorId colorId, BrandId brandId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorId = colorId;
        BrandId = brandId;
        ModelId = modelId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Car Create(int engineVolume, string? description, ColorId colorId, BrandId brandId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime)
    {
        return new Car(CarId.CreateUnique(), engineVolume, description, colorId, brandId, modelId, createDateTime, updateDateTime);
    }
    
#pragma warning disable CS8618 
    private Car() { }
#pragma warning restore CS8618
}