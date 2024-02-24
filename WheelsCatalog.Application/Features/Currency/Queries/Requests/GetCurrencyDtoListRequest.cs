using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests;

public class GetCurrencyDtoListRequest : IRequest<PaginatedList<RespondCurrencyDto>>
{
    public PaginationParameters? PaginationParameters { get; init; }
}