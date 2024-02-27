using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoDetailsHandler : IRequestHandler<GetBrandDtoDetailsRequest, RespondBrandDtoDetails>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IModelRepository _modelRepository;
    private readonly IMapper _mapper;

    public GetBrandDtoDetailsHandler(IBrandRepository brandRepository, IMapper mapper, IModelRepository modelRepository)
    {
        _mapper = mapper;
        _brandRepository = brandRepository;
        _modelRepository = modelRepository;
    }

    public async Task<RespondBrandDtoDetails> Handle(GetBrandDtoDetailsRequest request, CancellationToken cancellationToken)
    {
        var brand = await _brandRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(request.Id!.Value);

        var respond = _mapper.Map<RespondBrandDtoDetails>(brand);
        var modelsByBrand = await _modelRepository.GetAllByBrandIdAsync(brand.Id.Value, cancellationToken);
        respond.ModelDtos = modelsByBrand.Count == 0 ? new List<RespondModelDto>() : _mapper.Map<List<RespondModelDto>>(modelsByBrand);

        return respond;
    }
}