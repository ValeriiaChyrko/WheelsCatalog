using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
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
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var colors = await _repository.ListAsync(pageNumber, pageSize, cancellationToken);
        var respondColorsDtos = _mapper.Map<List<RespondColorDto>>(colors);

        return new PaginatedList<RespondColorDto>(respondColorsDtos, pageNumber);
    }
}