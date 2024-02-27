using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoEngineVolumeMinHandler : IRequestHandler<GetCarDtoEngineVolumeMinRequest, double>
{
    private readonly ICarRepository _repository;

    public GetCarDtoEngineVolumeMinHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<double> Handle(GetCarDtoEngineVolumeMinRequest request, CancellationToken cancellationToken)
    {
        return await _repository.GetCarDtoEngineVolumeMin() ?? 0;
    }
}