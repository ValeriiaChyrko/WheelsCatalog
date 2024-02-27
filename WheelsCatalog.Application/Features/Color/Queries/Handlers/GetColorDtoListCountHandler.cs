using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoListCountHandler : IRequestHandler<GetColorDtoListCountRequest, int>
{
    private readonly IColorRepository _repository;

    public GetColorDtoListCountHandler(IColorRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetColorDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return  await _repository.CountAsync(cancellationToken);
    }
}