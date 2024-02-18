using WheelsCatalog.Application.dtos.sharedDtos;

namespace WheelsCatalog.Application.dtos.requestsDtos;

public class RequestBrandDto
{
    public required string Name { get; set; } 
    public required FileDto Logo { get; set; } 
    public string? Description { get; set; } 
}