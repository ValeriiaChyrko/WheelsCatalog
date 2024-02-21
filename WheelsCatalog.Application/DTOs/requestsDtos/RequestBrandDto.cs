using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestBrandDto
{
    public string? Name { get; set; } 
    public FileDto? Logo { get; set; } 
    public string? Description { get; set; } 
}