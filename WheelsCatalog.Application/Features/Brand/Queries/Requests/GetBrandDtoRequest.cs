using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoRequest : IRequest<RespondBrandDto>
{
    public Guid? Id { get; set; }
}
