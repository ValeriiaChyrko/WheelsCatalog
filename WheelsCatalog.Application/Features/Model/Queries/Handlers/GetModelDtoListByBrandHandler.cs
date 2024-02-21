using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListByBrandHandler : IRequestHandler<GetModelDtoListByBrandRequest, List<RespondModelDto>>
{
    private readonly IModelRepository _repository;
    private readonly IMapper _mapper;

    public GetModelDtoListByBrandHandler(IModelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondModelDto>> Handle(GetModelDtoListByBrandRequest request, CancellationToken cancellationToken)
    {
        var brandId = request.Id!.Value;
        var modelsByBrand = await _repository.GetAllByBrandIdAsync(BrandId.Create(brandId), cancellationToken);
        return modelsByBrand.Count == 0 ? new List<RespondModelDto>() : _mapper.Map<List<RespondModelDto>>(modelsByBrand);
    }
}