using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class CreateModelHandler : IRequestHandler<CreateModelRequest, ModelId>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateModelHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ModelId> Handle(CreateModelRequest command, CancellationToken cancellationToken)
    {
        var brandId = command.ModelDto!.BrandId!.Value;
        
        var model = Domain.ModelAggregate.Model.Create(command.ModelDto!.Name!, command.ModelDto.Description, BrandId.Create(brandId)); 
        await _unitOfWork.ModelRepository.AddAsync(model, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return model.Id;
    }
}