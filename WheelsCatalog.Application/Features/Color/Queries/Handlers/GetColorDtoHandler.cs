using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoHandler : IRequestHandler<GetColorDtoRequest, RespondColorDto>
{
    private readonly IColorRepository _repository;
    private readonly IMapper _mapper;

    public GetColorDtoHandler(IColorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RespondColorDto> Handle(GetColorDtoRequest request, CancellationToken cancellationToken)
    {
        var color = await _repository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (color == null) throw new NotFoundRequestException(request.Id!.Value);

        return _mapper.Map<RespondColorDto>(color);
    }
}