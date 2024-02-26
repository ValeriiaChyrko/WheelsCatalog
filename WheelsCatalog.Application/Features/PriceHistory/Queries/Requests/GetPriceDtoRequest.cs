using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

public class GetPriceDtoRequest : IRequest<RespondPriceDto>
{
    public Guid? CarId { get; init; }
    public DateTime? Date { get; init; }
}
