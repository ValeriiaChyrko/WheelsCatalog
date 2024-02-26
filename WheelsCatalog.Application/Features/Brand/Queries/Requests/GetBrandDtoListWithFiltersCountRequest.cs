using MediatR;
using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoListWithFiltersCountRequest : IRequest<int>
{
    public BrandFilteringParameters? FilteringParameters { get; init; }
}