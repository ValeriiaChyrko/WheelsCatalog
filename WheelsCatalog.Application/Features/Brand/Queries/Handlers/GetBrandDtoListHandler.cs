using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListHandler : IRequestHandler<GetBrandDtoListWithFiltersRequest, PaginatedList<RespondBrandDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public GetBrandDtoListHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondBrandDto>> Handle(GetBrandDtoListWithFiltersRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.FilteringParameters;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;

        var brands = await _unitOfWork.BrandRepository.GetAllByFilterAsync(pageNumber, pageSize, request.FilteringParameters, cancellationToken);
        var respondBrands = _mapper.Map<List<RespondBrandDto>>(brands);
        
        return new PaginatedList<RespondBrandDto>(respondBrands, pageNumber, pageSize);
    }
}