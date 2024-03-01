using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Handlers;

public class DeleteModelHandler : IRequestHandler<DeleteModelRequest, ModelId>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteModelHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ModelId> Handle(DeleteModelRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var model = await _unitOfWork.ModelRepository.GetByIdAsync(id, cancellationToken);
        if (model == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Model", Id = id});
        
        await _unitOfWork.ModelRepository.DeleteAsync(model, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return model.Id;
    }
}