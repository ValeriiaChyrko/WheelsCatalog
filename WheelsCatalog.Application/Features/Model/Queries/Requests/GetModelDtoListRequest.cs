using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListRequest : IRequest<PaginatedList<RespondModelDto>>
{
    public PaginationParameters? PaginationParameters { get; init; }
}