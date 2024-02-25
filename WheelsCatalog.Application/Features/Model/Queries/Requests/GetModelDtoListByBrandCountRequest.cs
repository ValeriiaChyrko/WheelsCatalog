using MediatR;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListByBrandCountRequest : IRequest<int> 
{
    public Guid? Id { get; init; }
}
