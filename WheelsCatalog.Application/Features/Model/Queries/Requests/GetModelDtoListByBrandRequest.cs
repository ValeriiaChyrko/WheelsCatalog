using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListByBrandRequest : IRequest<List<RespondModelDto>> 
{
    public Guid? Id { get; set; }
}
