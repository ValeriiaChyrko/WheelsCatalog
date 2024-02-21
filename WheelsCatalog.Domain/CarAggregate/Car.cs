﻿using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.CarAggregate;

public sealed class Car : AggregateRoot<CarId>
{
    public double EngineVolume { get; private set; }
    public string? Description { get; private set; }
    public ColorId ColorId { get; private set; }
    public ModelId ModelId { get; private set; }
    
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    private Car(CarId id, double engineVolume, string? description, ColorId colorId, ModelId modelId, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorId = colorId;
        ModelId = modelId;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Car Create(double engineVolume, string? description, ColorId colorId, ModelId modelId)
    {
        var carId = CarId.CreateUnique();
        var recordDateTime = DateTime.Now;
        
        var car = new Car(carId, engineVolume, description, colorId, modelId, recordDateTime, recordDateTime);
        return car;
    }
    
    public void Update(double engineVolume, string? description, ColorId colorId, ModelId modelId)
    {
        EngineVolume = engineVolume;
        Description = description;
        ColorId = colorId;
        ModelId = modelId;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618 
    public Car(){}
#pragma warning restore CS8618 
}