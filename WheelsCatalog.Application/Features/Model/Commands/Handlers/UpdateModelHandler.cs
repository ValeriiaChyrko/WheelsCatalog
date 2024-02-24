using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class UpdateModelHandler : IRequestHandler<UpdateModelRequest, ModelId>
{
    private readonly IModelRepository _repository;

    public UpdateModelHandler(IModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<ModelId> Handle(UpdateModelRequest command, CancellationToken cancellationToken)
    {
        var model = await _repository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (model == null) throw new NotFoundRequestException(command.Id!.Value);
        
        var brandId = command.ModelDto!.BrandId!.Value;
        model.Update(command.ModelDto!.Name!, command.ModelDto.Description, BrandId.Create(brandId));
        await _repository.UpdateAsync(model, cancellationToken);

        return model.Id;
    }
}