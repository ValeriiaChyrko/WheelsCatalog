using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoListCountHandler : IRequestHandler<GetCurrencyDtoListCountRequest, int>
{
    private readonly ICurrencyRepository _repository;

    public GetCurrencyDtoListCountHandler(ICurrencyRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetCurrencyDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountAsync(cancellationToken);
    }
}