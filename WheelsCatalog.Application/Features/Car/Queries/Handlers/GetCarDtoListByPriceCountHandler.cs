using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByPriceCountHandler : IRequestHandler<GetCarDtoListByPriceCountRequest, int>
{
    private readonly ICarRepository _repository;

    public GetCarDtoListByPriceCountHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCarDtoListByPriceCountRequest request, CancellationToken cancellationToken)
    {
        var priceFilteringParameters = request.PriceFilteringParameters;
        var startDate = priceFilteringParameters?.Date ?? DateTime.Now;
        var minPrice = priceFilteringParameters?.MinPrice ?? int.MinValue;
        var maxPrice = priceFilteringParameters?.MaxPrice ?? int.MaxValue;
        
        var carsByPriceAmount = await _repository.CountByPriceFiltersAsync(startDate, minPrice, maxPrice, cancellationToken);

        return carsByPriceAmount;
    }
}