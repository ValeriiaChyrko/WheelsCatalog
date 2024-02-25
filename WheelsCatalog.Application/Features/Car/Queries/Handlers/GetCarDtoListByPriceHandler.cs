using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByPriceHandler : IRequestHandler<GetCarDtoListByPriceRequest, PaginatedList<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListByPriceHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListByPriceRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var priceFilteringParameters = request.PriceFilteringParameters;
        var startDate = priceFilteringParameters?.Date ?? DateTime.Now;
        var minPrice = priceFilteringParameters?.MinPrice ?? int.MinValue;
        var maxPrice = priceFilteringParameters?.MaxPrice ?? int.MaxValue;
        
        var carsByPrice = await _repository.GetAllByPriceIdAsync(pageNumber, pageSize, startDate, minPrice, maxPrice, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(carsByPrice);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageSize);
    }
}