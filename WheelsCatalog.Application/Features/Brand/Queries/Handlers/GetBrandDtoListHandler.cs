using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListHandler : IRequestHandler<GetBrandDtoListRequest, PaginatedList<RespondBrandDto>>
{
    private readonly IBrandRepository _repository;
    private readonly IMapper _mapper;

    public GetBrandDtoListHandler(IBrandRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondBrandDto>> Handle(GetBrandDtoListRequest request, CancellationToken cancellationToken)
    {
        var totalItems = await _repository.CountAsync(cancellationToken);
        var pageSize = request.PaginationParameters?.Limit == 0 ? totalItems : request.PaginationParameters!.Limit;
        var pageNumber = request.PaginationParameters?.Page == 0 ? 1 : request.PaginationParameters!.Page;

        var brands = await _repository.ListAsync(pageNumber, pageSize, cancellationToken);
        var respondBrands = _mapper.Map<List<RespondBrandDto>>(brands);
        
        return new PaginatedList<RespondBrandDto>(respondBrands, pageSize, pageNumber, totalItems);
    }
}