using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoRequest : IRequest<RespondModelDto>
{
    public Guid? Id { get; init; }
}
