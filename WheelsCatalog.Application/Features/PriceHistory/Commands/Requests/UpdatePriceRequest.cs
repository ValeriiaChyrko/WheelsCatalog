using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;

public class UpdatePriceRequest : IRequest<PriceHistoryId>
{
    public Guid? Id { get; init; }
    public RequestPriceDto? PriceDto { get; init; }
}