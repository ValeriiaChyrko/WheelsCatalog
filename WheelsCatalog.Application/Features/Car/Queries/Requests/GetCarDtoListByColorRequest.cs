using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByColorRequest : IRequest<PaginatedList<RespondCarDto>> 
{
    public Guid? Id { get; set; }
    public PaginationParameters? PaginationParameters { get; init; }
}
