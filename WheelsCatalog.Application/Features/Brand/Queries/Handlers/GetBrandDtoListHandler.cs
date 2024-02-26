using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListHandler : IRequestHandler<GetBrandDtoListWithFiltersRequest, PaginatedList<RespondBrandDto>>
{
    private readonly IBrandRepository _repository;
    private readonly IMapper _mapper;

    public GetBrandDtoListHandler(IBrandRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondBrandDto>> Handle(GetBrandDtoListWithFiltersRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;

        var brands = await _repository.GetAllByFilterAsync(pageNumber, pageSize, request.FilteringParameters, cancellationToken);
        var respondBrands = _mapper.Map<List<RespondBrandDto>>(brands);
        
        return new PaginatedList<RespondBrandDto>(respondBrands, pageNumber);
    }
}