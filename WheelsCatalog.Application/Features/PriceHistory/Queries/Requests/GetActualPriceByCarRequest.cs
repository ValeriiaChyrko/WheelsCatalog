using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

public class GetActualPriceByCarRequest : IRequest<RespondPriceDto> 
{
    public Guid? CarId { get; init; }
}
