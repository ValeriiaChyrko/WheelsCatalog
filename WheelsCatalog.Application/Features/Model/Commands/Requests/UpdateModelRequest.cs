using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests;

public class UpdateModelRequest : IRequest<ModelId>
{
    public Guid? Id { get; init; }
    public RequestModelDto? ModelDto { get; init; }
}