using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests;

public class GetCurrencyDtoRequest : IRequest<RespondCurrencyDto>
{
    public Guid? Id { get; set; }
}
