using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListWithFiltersCountHandler : IRequestHandler<GetCarDtoListWithFiltersCountRequest, int>
{
    private readonly ICarRepository _repository;

    public GetCarDtoListWithFiltersCountHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCarDtoListWithFiltersCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountWithFiltersAsync(request.CarFilteringParameters, request.PriceFilteringParameters, cancellationToken);
    }
}