using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoHandler : IRequestHandler<GetColorDtoRequest, RespondColorDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetColorDtoHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<RespondColorDto> Handle(GetColorDtoRequest request, CancellationToken cancellationToken)
    {
        var color = await _unitOfWork.ColorRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (color == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Color", Id = request.Id!.Value});

        return _mapper.Map<RespondColorDto>(color);
    }
}