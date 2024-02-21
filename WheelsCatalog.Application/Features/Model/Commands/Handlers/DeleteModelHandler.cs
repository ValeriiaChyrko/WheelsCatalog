using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class DeleteModelHandler : IRequestHandler<DeleteModelRequest, ModelId>
{
    private readonly IModelRepository _repository;

    public DeleteModelHandler(IModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<ModelId> Handle(DeleteModelRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var model = await _repository.GetByIdAsync(id, cancellationToken);
        if (model == null) throw new NotFoundRequestException(id);
        
        await _repository.DeleteAsync(model, cancellationToken);
        return model.Id;
    }
}