using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests;

public class UpdateCarRequest : IRequest<CarId>
{
    public Guid? Id { get; init; }
    public required RequestCarDto? CarDto { get; init; }
}