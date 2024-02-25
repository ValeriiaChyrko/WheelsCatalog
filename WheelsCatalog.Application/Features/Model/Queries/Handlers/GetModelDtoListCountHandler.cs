using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListCountHandler : IRequestHandler<GetModelDtoListCountRequest, int>
{
    private readonly IModelRepository _repository;

    public GetModelDtoListCountHandler(IModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetModelDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountAsync(cancellationToken);
    }
}