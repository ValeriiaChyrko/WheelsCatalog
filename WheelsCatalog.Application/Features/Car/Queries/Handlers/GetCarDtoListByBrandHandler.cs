using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByBrandHandler : IRequestHandler<GetCarDtoListByBrandRequest, PaginatedList<RespondCarDto>>
{
    private readonly ICarRepository _carRepository;
    private readonly IModelRepository _modelRepository;
    private readonly IMapper _mapper;

    public GetCarDtoListByBrandHandler(ICarRepository carRepository, IMapper mapper, IModelRepository modelRepository)
    {
        _modelRepository = modelRepository;
        _carRepository = carRepository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListByBrandRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var brandId = request.Id!.Value;
        var modelsByBrand = await _modelRepository.GetAllByBrandIdAsync(BrandId.Create(brandId), cancellationToken);
        var modelIds = modelsByBrand.Select(model => model.Id).ToList();
        
        var carsByModel = await _carRepository.GetAllByModelIdsAsync(pageNumber, pageSize, modelIds, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(carsByModel);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageNumber);
    }
}