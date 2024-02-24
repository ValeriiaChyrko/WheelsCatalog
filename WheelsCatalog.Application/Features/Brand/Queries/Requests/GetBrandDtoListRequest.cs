using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoListRequest : IRequest<PaginatedList<RespondBrandDto>>
{
    public PaginationParameters? PaginationParameters { get; init; }
}