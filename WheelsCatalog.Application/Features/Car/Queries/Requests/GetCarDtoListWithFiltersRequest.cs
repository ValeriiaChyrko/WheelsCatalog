using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListWithFiltersRequest : IRequest<PaginatedList<RespondCarDto>>
{
    public CarFilteringParameters? CarFilteringParameters { get; init; }
    public PriceFilteringParameters? PriceFilteringParameters { get; init; }
}