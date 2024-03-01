using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoListCountHandler : IRequestHandler<GetCurrencyDtoListCountRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetCurrencyDtoListCountHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(GetCurrencyDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.CurrencyRepository.CountAsync(cancellationToken);
    }
}