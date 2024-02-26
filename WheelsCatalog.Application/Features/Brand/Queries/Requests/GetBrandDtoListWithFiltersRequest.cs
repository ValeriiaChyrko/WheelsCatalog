using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoListWithFiltersRequest : IRequest<PaginatedList<RespondBrandDto>>
{
    public BrandFilteringParameters? FilteringParameters { get; init; }
    public PaginationParameters? PaginationParameters { get; init; }
}