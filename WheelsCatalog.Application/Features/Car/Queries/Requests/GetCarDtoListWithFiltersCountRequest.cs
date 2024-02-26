using MediatR;
using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListWithFiltersCountRequest : IRequest<int>
{
    public CarFilteringParameters? CarFilteringParameters { get; set; }
    public PriceFilteringParameters? PriceFilteringParameters { get; set; }
}