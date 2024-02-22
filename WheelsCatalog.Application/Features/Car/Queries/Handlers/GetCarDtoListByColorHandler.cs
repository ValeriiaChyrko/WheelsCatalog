using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByColorHandler : IRequestHandler<GetCarDtoListByColorRequest, List<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListByColorHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondCarDto>> Handle(GetCarDtoListByColorRequest request, CancellationToken cancellationToken)
    {
        var colorId = request.Id!.Value;
        var carsByModel = await _repository.GetAllByColorIdAsync(ColorId.Create(colorId), cancellationToken);
        return carsByModel.Count == 0 ? new List<RespondCarDto>() : _mapper.Map<List<RespondCarDto>>(carsByModel);
    }
}