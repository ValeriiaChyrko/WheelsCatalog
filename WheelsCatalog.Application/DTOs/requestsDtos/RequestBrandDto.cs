using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestBrandDto
{
    public string? Name { get; init; } 
    public FileDto? Logo { get; init; } 
    public string? Description { get; init; } 
}