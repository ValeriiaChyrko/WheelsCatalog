using MediatR;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByColorCountRequest : IRequest<int> 
{
    public Guid? Id { get; set; }
}
