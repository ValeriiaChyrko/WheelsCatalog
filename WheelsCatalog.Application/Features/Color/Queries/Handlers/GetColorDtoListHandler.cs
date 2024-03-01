using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoListHandler : IRequestHandler<GetColorDtoListRequest, List<RespondColorDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetColorDtoListHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<RespondColorDto>> Handle(GetColorDtoListRequest request, CancellationToken cancellationToken)
    {
       
        var colors = await _unitOfWork.ColorRepository.ListAsync(cancellationToken);
        var respondColorsDtos = _mapper.Map<List<RespondColorDto>>(colors);

        return new List<RespondColorDto>(respondColorsDtos);
    }
}