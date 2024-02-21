using MediatR;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests;

public class DeleteModelRequest : IRequest<ModelId>
{
    public Guid? Id { get; init; }
}