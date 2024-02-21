using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Commands.Requests;

public class CreateModelRequest : IRequest<ModelId>
{
    public required RequestModelDto? ModelDto { get; init; }
}