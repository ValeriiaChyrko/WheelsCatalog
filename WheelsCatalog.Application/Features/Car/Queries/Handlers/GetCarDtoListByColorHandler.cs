using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByColorHandler : IRequestHandler<GetCarDtoListByColorRequest, PaginatedList<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListByColorHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListByColorRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        var colorId = ColorId.Create(request.Id!.Value);
        
        var carsByColor = await _repository.GetAllByColorIdAsync(pageNumber, pageSize, colorId, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(carsByColor);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageNumber);
    }
}