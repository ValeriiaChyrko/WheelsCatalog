using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoDetailsRequest: IRequest<RespondBrandDtoDetails>
{
    public Guid? Id { get; set; }
}
