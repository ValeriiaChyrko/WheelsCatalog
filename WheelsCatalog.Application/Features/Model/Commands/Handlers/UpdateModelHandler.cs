using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class UpdateModelHandler : IRequestHandler<UpdateModelRequest, ModelId>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateModelHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ModelId> Handle(UpdateModelRequest command, CancellationToken cancellationToken)
    {
        var model = await _unitOfWork.ModelRepository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (model == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Model", Id = command.Id.Value});
        
        var brandId = command.ModelDto!.BrandId!.Value;
        model.Update(command.ModelDto!.Name!, command.ModelDto.Description, BrandId.Create(brandId));
        await _unitOfWork.ModelRepository.UpdateAsync(model, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return model.Id;
    }
}