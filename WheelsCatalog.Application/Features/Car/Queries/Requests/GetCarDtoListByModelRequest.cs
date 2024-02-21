using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByModelRequest : IRequest<List<RespondCarDto>> 
{
    public Guid? Id { get; set; }
}
