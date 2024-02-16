using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.BrandAggregate.Events;

public record BrandCreated(Brand Brand) : IDomainEvent;