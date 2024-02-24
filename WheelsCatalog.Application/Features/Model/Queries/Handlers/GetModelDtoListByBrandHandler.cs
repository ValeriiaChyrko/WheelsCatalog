using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListByBrandHandler : IRequestHandler<GetModelDtoListByBrandRequest, PaginatedList<RespondModelDto>>
{
    private readonly IModelRepository _repository;
    private readonly IMapper _mapper;

    public GetModelDtoListByBrandHandler(IModelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondModelDto>> Handle(GetModelDtoListByBrandRequest request, CancellationToken cancellationToken)
    {
        var brandId = request.Id!.Value;
        var modelsByBrand = await _repository.GetAllByBrandIdAsync(BrandId.Create(brandId), cancellationToken);
        
        var respondModelDtos = _mapper.Map<List<RespondModelDto>>(modelsByBrand);

        var pageSize = request.PaginationParameters?.Limit ?? respondModelDtos.Count();
        var currentPage = request.PaginationParameters?.Page ?? 1;
        var totalItems = await _repository.CountAsync(cancellationToken);

        return new PaginatedList<RespondModelDto>(respondModelDtos, pageSize, currentPage, totalItems);
    }
}