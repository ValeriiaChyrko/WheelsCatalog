using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class CreateModelHandler : IRequestHandler<CreateModelRequest, ModelId>
{
    private readonly IModelRepository _repository;

    public CreateModelHandler(IModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<ModelId> Handle(CreateModelRequest command, CancellationToken cancellationToken)
    {
        var brandId = command.ModelDto!.BrandId!.Value;
        
        var model = Domain.ModelAggregate.Model.Create(command.ModelDto!.Name!, command.ModelDto.Description, BrandId.Create(brandId)); 
        await _repository.AddAsync(model, cancellationToken);

        return model.Id;
    }
}