using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.ModelAggregate.Events;

public record ModelUpdated(ModelId ModelId, BrandId BrandId) : IDomainEvent;