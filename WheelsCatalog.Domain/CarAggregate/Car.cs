﻿using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Domain.CarAggregate;

public sealed class Car : AggregateRoot<CarId>
{
    public int EngineVolume { get; private set; }
    public string? Description { get; private set; }
    public ColorId ColorId { get; private set; }
    public BrandId BrandId { get; private set; }
    public ModelId ModelId { get; private set; }

    private readonly List<CarPhotoId> _photoIds = new();
    public IReadOnlyCollection<CarPhotoId> CarPhotoIds => _photoIds.AsReadOnly();
    
    private readonly List<PriceHistoryId> _priceHistoryIds = new();
    public IReadOnlyCollection<PriceHistoryId> PriceHistoryIds => _priceHistoryIds.AsReadOnly();
    
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private Car(CarId id, int engineVolume, string? description, ColorId colorId, BrandId brandId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorId = colorId;
        BrandId = brandId;
        ModelId = modelId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Car Create(int engineVolume, string? description, ColorId colorId, BrandId brandId, ModelId modelId)
    {
        var carId = CarId.CreateUnique();
        var recordDateTime = DateTime.Now;
        return new Car(carId, engineVolume, description, colorId, brandId, modelId, recordDateTime, recordDateTime);
    }
    
    public void Update(int engineVolume, string? description, ColorId colorId, BrandId brandId, ModelId modelId)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorId = colorId;
        BrandId = brandId;
        ModelId = modelId;
        UpdateDateTime = DateTime.Now;
    }
    
    public void AddPhotoId(CarPhotoId photoId)
    {
        _photoIds.Add(photoId);
    }
    
    public void AddPriceHistory(PriceHistoryId priceHistoryId)
    {
        _priceHistoryIds.Add(priceHistoryId);
    }

#pragma warning disable CS8618 
    public Car(){}
#pragma warning restore CS8618 
}