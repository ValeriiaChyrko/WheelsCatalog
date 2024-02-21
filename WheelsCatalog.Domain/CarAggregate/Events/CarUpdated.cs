using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Domain.CarAggregate.Events;

public record CarUpdated(CarId CarId, ModelId ModelId) : IDomainEvent;