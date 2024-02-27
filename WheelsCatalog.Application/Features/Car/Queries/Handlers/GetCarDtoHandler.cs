using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoHandler : IRequestHandler<GetCarDtoRequest, RespondCarDto>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RespondCarDto> Handle(GetCarDtoRequest request, CancellationToken cancellationToken)
    {
        var car = await _repository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(request.Id!.Value);

        return _mapper.Map<RespondCarDto>(car);
    }
}