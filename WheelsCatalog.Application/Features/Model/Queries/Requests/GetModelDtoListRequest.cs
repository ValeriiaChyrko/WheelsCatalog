using MediatR;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests;

public class GetModelDtoListRequest : IRequest<List<RespondModelDto>> { }