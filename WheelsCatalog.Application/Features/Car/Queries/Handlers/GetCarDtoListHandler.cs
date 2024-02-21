using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListHandler : IRequestHandler<GetCarDtoListRequest, List<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondCarDto>> Handle(GetCarDtoListRequest request, CancellationToken cancellationToken)
    {
        var cars = await _repository.ListAsync(cancellationToken);
        return cars.Count == 0 ? new List<RespondCarDto>() : _mapper.Map<List<RespondCarDto>>(cars);
    }
}