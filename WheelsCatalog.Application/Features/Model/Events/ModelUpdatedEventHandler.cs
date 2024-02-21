using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.ModelAggregate.Events;

namespace WheelsCatalog.Application.Features.Model.Events;

public class ModelUpdatedEventHandler: INotificationHandler<ModelUpdated>
{
    private readonly IBrandRepository _brandRepository;

    public ModelUpdatedEventHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task Handle(ModelUpdated notification, CancellationToken cancellationToken)
    {

    }
}