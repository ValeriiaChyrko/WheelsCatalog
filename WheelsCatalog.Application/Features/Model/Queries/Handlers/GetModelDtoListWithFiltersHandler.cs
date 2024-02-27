using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListWithFiltersHandler : IRequestHandler<GetModelDtoListWithFiltersRequest, PaginatedList<RespondModelDto>>
{
    private readonly IModelRepository _repository;
    private readonly IMapper _mapper;

    public GetModelDtoListWithFiltersHandler(IModelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondModelDto>> Handle(GetModelDtoListWithFiltersRequest request, CancellationToken cancellationToken)
    {
        var filteringParameters = request.FilteringParameters;
        var pageSize = filteringParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = filteringParameters?.Page ?? Constants.DefaultPageNumber;
        
        var modelsByFilter = await _repository.GetAllByFilterAsync(pageNumber, pageSize, request.FilteringParameters, cancellationToken);

        var respondModelDtos = _mapper.Map<List<RespondModelDto>>(modelsByFilter);

        return new PaginatedList<RespondModelDto>(respondModelDtos, pageNumber, pageSize);
    }
}