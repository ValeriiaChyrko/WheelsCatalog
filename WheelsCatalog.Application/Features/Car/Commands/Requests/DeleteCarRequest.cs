using MediatR;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests;

public class DeleteCarRequest : IRequest<CarId>
{
    public Guid? Id { get; init; }
}