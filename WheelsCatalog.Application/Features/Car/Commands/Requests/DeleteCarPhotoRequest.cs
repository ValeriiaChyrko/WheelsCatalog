using MediatR;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests;

public class DeleteCarDtoPhotosRequest : IRequest<CarPhotoId>
{
    public Guid? Id { get; init; }
}