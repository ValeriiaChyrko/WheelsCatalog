using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListWithFiltersCountHandler : IRequestHandler<GetModelDtoListCountRequest, int>
{
    private readonly IModelRepository _repository;

    public GetModelDtoListWithFiltersCountHandler(IModelRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetModelDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountWithFiltersAsync(request.FilteringParameters, cancellationToken);
    }
}