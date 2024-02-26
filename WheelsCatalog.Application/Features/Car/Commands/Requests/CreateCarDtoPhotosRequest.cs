using MediatR;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests;

public class CreateCarDtoPhotosRequest : IRequest<CarPhotoId>
{
    public Guid? CarId { get; init; }
    public FileDto? Photo { get; init; }
}