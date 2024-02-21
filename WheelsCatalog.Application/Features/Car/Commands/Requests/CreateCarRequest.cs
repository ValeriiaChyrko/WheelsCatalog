using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests;

public class CreateCarRequest : IRequest<CarId>
{
    public required RequestCarDto? CarDto { get; init; }
}