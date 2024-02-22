using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;

public class CreatePriceRequest : IRequest<PriceHistoryId>
{
    public required RequestPriceDto? PriceDto { get; init; }
}