using WheelsCatalog.Domain.Common.Models;

namespace WheelsCatalog.Domain.BrandAggregate.Events;

public record BrandUpdated(Brand Brand) : IDomainEvent;