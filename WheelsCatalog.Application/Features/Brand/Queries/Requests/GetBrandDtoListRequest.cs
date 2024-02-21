using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests;

public class GetBrandDtoListRequest : IRequest<List<RespondBrandDto>> { }