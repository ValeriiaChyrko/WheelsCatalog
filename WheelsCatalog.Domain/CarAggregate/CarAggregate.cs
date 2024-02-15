using WheelsCatalog.Domain.Brand.ValueObjects;
using WheelsCatalog.Domain.Car.Entities;
using WheelsCatalog.Domain.Car.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.Model.ValueObjects;

namespace WheelsCatalog.Domain.Car;

public sealed class CarAggregate : AggregateRoot<CarId>
{
    public int EngineVolume { get; }
    public string? Description { get; }
    public ColorEntity ColorEntity { get; }
    
    public BrandId BrandId { get; }
    public ModelId ModelId { get; }

    private readonly List<CarPhotoEntity> _photos = new();
    public IReadOnlyCollection<CarPhotoEntity> Photos => _photos.AsReadOnly();
    
    private readonly List<PriceHistory.PriceHistoryAggregate> _priceHistories = new();
    public IReadOnlyCollection<PriceHistory.PriceHistoryAggregate> PriceHistories => _priceHistories.AsReadOnly();
    
    public DateTime CreateDateTime { get; }
    public DateTime UpdateDateTime { get; }

    public CarAggregate(CarId id, int engineVolume, string? description, ColorEntity colorEntity, BrandId brandId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorEntity = colorEntity;
        BrandId = brandId;
        ModelId = modelId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static CarAggregate Create(int engineVolume, string? description, ColorEntity colorEntity, BrandId brandId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime)
    {
        return new CarAggregate(CarId.CreateUnique(), engineVolume, description, colorEntity, brandId, modelId, createDateTime, updateDateTime);
    }
}