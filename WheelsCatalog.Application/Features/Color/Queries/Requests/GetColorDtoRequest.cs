using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests;

public class GetColorDtoRequest : IRequest<RespondColorDto>
{
    public Guid? Id { get; init; }
}
