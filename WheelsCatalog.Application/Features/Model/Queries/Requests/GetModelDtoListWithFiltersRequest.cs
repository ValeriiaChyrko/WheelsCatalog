using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListWithFiltersRequest : IRequest<PaginatedList<RespondModelDto>>
{
    public ModelFilteringParameters? FilteringParameters { get; init; }
}