using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByBrandHandler : IRequestHandler<GetCarDtoListByBrandRequest, List<RespondCarDto>>
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

    public async Task<List<RespondCarDto>> Handle(GetCarDtoListByBrandRequest request, CancellationToken cancellationToken)
    {
        var brandId = request.Id!.Value;
        var modelsByBrand = await _modelRepository.GetAllByBrandIdAsync(BrandId.Create(brandId), cancellationToken);
        var modelIds = modelsByBrand.Select(model => model.Id).ToList();
        
        var carsByModel = await _carRepository.GetAllByModelIdsAsync(modelIds, cancellationToken);
        return carsByModel.Count == 0 ? new List<RespondCarDto>() : _mapper.Map<List<RespondCarDto>>(carsByModel);
    }
}