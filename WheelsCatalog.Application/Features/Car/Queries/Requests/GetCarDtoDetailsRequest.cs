using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoDetailsRequest: IRequest<RespondCarDtoDetails>
{
    public Guid? Id { get; set; }
}
