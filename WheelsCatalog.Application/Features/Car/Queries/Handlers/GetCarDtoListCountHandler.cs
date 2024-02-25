using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListCountHandler : IRequestHandler<GetCarDtoListCountRequest, int>
{
    private readonly ICarRepository _repository;

    public GetCarDtoListCountHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCarDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountAsync(cancellationToken);
    }
}