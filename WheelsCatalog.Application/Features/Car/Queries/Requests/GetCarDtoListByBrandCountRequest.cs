using MediatR;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByBrandCountRequest : IRequest<int> 
{
    public Guid? Id { get; set; }
}
