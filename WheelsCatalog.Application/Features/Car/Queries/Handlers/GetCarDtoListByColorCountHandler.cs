using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByColorCountHandler : IRequestHandler<GetCarDtoListByColorCountRequest, int>
{
    private readonly ICarRepository _repository;

    public GetCarDtoListByColorCountHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCarDtoListByColorCountRequest request, CancellationToken cancellationToken)
    {
        var colorId = ColorId.Create(request.Id!.Value);
        return await _repository.CountByColorIdAsync(colorId, cancellationToken);
    }
}