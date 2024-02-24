using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListByBrandRequest : IRequest<PaginatedList<RespondModelDto>> 
{
    public Guid? Id { get; init; }
    public PaginationParameters? PaginationParameters { get; init; }
}
