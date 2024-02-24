using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoListHandler : IRequestHandler<GetColorDtoListRequest, PaginatedList<RespondColorDto>>
{
    private readonly IColorRepository _repository;
    private readonly IMapper _mapper;

    public GetColorDtoListHandler(IColorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondColorDto>> Handle(GetColorDtoListRequest request, CancellationToken cancellationToken)
    {
        var totalItems = await _repository.CountAsync(cancellationToken);
        var pageSize = request.PaginationParameters?.Limit == 0 ? totalItems : request.PaginationParameters!.Limit;
        var pageNumber = request.PaginationParameters?.Page == 0 ? 1 : request.PaginationParameters!.Page;
        
        var colors = await _repository.ListAsync(pageNumber, pageSize, cancellationToken);
        var respondColorsDtos = _mapper.Map<List<RespondColorDto>>(colors);

        return new PaginatedList<RespondColorDto>(respondColorsDtos, pageSize, pageNumber, totalItems);
    }
}