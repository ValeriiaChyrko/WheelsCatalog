namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondModelDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; } 
    public Guid? BrandId { get; set; }
}