using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByBrandCountHandler : IRequestHandler<GetCarDtoListByBrandCountRequest, int>
{
    private readonly ICarRepository _carRepository;
    private readonly IModelRepository _modelRepository;

    public GetCarDtoListByBrandCountHandler(ICarRepository carRepository, IModelRepository modelRepository)
    {
        _modelRepository = modelRepository;
        _carRepository = carRepository;
    }

    public async Task<int> Handle(GetCarDtoListByBrandCountRequest request, CancellationToken cancellationToken)
    {
        var brandId = request.Id!.Value;
        var modelsByBrand = await _modelRepository.GetAllByBrandIdAsync(BrandId.Create(brandId), cancellationToken);
        var modelIds = modelsByBrand.Select(model => model.Id).ToList();
        
        return await _carRepository.CountByModelIdsAsync(modelIds, cancellationToken);
    }
}