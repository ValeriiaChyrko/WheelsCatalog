using MediatR;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;

public class DeletePriceRequest : IRequest<PriceHistoryId>
{
    public Guid? Id { get; init; }
}