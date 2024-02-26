using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoRequest : IRequest<RespondCarDto>
{
    public Guid? Id { get; init; }
}
