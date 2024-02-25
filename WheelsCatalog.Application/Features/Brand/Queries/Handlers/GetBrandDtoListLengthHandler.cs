using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListLengthHandler : IRequestHandler<GetBrandDtoListLengthRequest, int>
{
    private readonly IBrandRepository _repository;

    public GetBrandDtoListLengthHandler(IBrandRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(GetBrandDtoListLengthRequest request, CancellationToken cancellationToken)
    {
        return await _repository.CountAsync(cancellationToken);
    }
}