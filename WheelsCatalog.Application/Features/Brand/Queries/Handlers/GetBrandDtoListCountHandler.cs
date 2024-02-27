using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListCountHandler : IRequestHandler<GetBrandDtoListWithFiltersCountRequest, int>
{
    private readonly IBrandRepository _repository;

    public GetBrandDtoListCountHandler(IBrandRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetBrandDtoListWithFiltersCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountWithFiltersAsync(request.FilteringParameters, cancellationToken);
    }
}