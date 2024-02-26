using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByModelCountHandler : IRequestHandler<GetCarDtoListByModelCountRequest, int>
{
    private readonly ICarRepository _repository;

    public GetCarDtoListByModelCountHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCarDtoListByModelCountRequest request, CancellationToken cancellationToken)
    {
        var modelId = request.Id!.Value;
        return await _repository.CountByModelIdAsync(modelId, cancellationToken);
    }
}