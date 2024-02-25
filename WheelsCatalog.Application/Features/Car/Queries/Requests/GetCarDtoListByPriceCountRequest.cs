using MediatR;
using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByPriceCountRequest  : IRequest<int>
{
    public PriceFilteringParameters? PriceFilteringParameters { get; init; }
}
