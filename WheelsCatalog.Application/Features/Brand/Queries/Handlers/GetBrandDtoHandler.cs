using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoHandler : IRequestHandler<GetBrandDtoRequest, RespondBrandDto>
{
    private readonly IBrandRepository _repository;
    private readonly IMapper _mapper;

    public GetBrandDtoHandler(IBrandRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RespondBrandDto> Handle(GetBrandDtoRequest request, CancellationToken cancellationToken)
    {
        var brand = await _repository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(request.Id!.Value);

        return _mapper.Map<RespondBrandDto>(brand);
    }
}