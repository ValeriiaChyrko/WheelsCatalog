using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListHandler : IRequestHandler<GetBrandDtoListRequest, List<RespondBrandDto>>
{
    private readonly IBrandRepository _repository;
    private readonly IMapper _mapper;

    public GetBrandDtoListHandler(IBrandRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondBrandDto>> Handle(GetBrandDtoListRequest request, CancellationToken cancellationToken)
    {
        var brands = await _repository.ListAsync(cancellationToken);
        return brands.Count == 0 ? new List<RespondBrandDto>() : _mapper.Map<List<RespondBrandDto>>(brands);
    }
}