using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByModelHandler : IRequestHandler<GetCarDtoListByModelRequest, List<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListByModelHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondCarDto>> Handle(GetCarDtoListByModelRequest request, CancellationToken cancellationToken)
    {
        var modelId = request.Id!.Value;
        var carsByModel = await _repository.GetAllByModelIdAsync(ModelId.Create(modelId), cancellationToken);
        return carsByModel.Count == 0 ? new List<RespondCarDto>() : _mapper.Map<List<RespondCarDto>>(carsByModel);
    }
}