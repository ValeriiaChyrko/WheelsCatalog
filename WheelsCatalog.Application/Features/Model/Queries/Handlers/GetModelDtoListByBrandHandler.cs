using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
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
        var brandId = BrandId.Create(request.Id!.Value);
        
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var carsByModel = await _repository.GetAllByBrandIdAsync(pageNumber, pageSize, brandId, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondModelDto>>(carsByModel);

        return new PaginatedList<RespondModelDto>(respondCarDtos, pageNumber);
    }
}