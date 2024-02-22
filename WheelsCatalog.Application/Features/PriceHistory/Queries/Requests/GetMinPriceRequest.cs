using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

public class GetMinPriceRequest : IRequest<RespondPriceDto>
{
    public DateTime? Date { get; init; }
}
