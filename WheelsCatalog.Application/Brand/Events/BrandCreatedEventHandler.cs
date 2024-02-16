using MediatR;
using WheelsCatalog.Domain.BrandAggregate.Events;

namespace WheelsCatalog.Application.Brand.Events;

public class BrandCreatedEventHandler : INotificationHandler<BrandCreated>
{
    public Task Handle(BrandCreated notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}