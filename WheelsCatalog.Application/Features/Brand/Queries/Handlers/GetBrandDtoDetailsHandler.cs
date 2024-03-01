using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoDetailsHandler : IRequestHandler<GetBrandDtoDetailsRequest, RespondBrandDtoDetails>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetBrandDtoDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondBrandDtoDetails> Handle(GetBrandDtoDetailsRequest request, CancellationToken cancellationToken)
    {
        var brand = await _unitOfWork.BrandRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Brand", Id = request.Id!.Value});

        var respond =  _mapper.Map<RespondBrandDtoDetails>(brand);
        var modelsByBrand = await _unitOfWork.ModelRepository.GetAllByBrandIdAsync(brand.Id.Value, cancellationToken);
        respond.ModelDtos = modelsByBrand.Count == 0 ? new List<RespondModelDto>() : _mapper.Map<List<RespondModelDto>>(modelsByBrand);

        return respond;
    }
}