namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondBrandDto 
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string LogoUrl { get; set; }  = string.Empty;
    public string? Description { get; set; } 
}