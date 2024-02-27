﻿using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoEngineVolumeMaxHandler : IRequestHandler<GetCarDtoEngineVolumeMaxRequest, double>
{
    private readonly ICarRepository _repository;

    public GetCarDtoEngineVolumeMaxHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<double> Handle(GetCarDtoEngineVolumeMaxRequest request, CancellationToken cancellationToken)
    {
        return await _repository.GetCarDtoEngineVolumeMax() ?? 0;
    }
}