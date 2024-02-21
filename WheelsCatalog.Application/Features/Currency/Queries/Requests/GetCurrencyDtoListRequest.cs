using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests;

public class GetCurrencyDtoListRequest : IRequest<List<RespondCurrencyDto>> { }