using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests;

public class GetColorDtoListRequest : IRequest<PaginatedList<RespondColorDto>>
{
    public PaginationParameters? PaginationParameters { get; init; }
}