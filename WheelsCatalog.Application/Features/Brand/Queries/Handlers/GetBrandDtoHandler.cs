using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoHandler : IRequestHandler<GetBrandDtoRequest, RespondBrandDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetBrandDtoHandler(IUnitOfWork repository, IMapper mapper)
    {
        _unitOfWork = repository;
        _mapper = mapper;
    }

    public async Task<RespondBrandDto> Handle(GetBrandDtoRequest request, CancellationToken cancellationToken)
    {
        var brand = await _unitOfWork.BrandRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Brand", Id = request.Id!.Value});

        return _mapper.Map<RespondBrandDto>(brand);
    }
}