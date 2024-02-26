using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListWithFiltersHandler : IRequestHandler<GetCarDtoListWithFiltersRequest, PaginatedList<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListWithFiltersHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListWithFiltersRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var cars = await _repository.GetAllByFilterAsync(
            pageNumber, 
            pageSize, 
            request.CarFilteringParameters,
            request.PriceFilteringParameters,
            cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(cars);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageNumber);
    }
}