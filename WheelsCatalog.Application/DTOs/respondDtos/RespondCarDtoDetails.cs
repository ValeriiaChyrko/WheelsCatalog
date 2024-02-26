namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondCarDtoDetails
{
    public Guid Id { get; set; } 
    public double EngineVolume { get; set; }
    public string? Description { get; set; }
    public string ModelName { get; set; } = string.Empty;
    public string ColorName { get; set; } = string.Empty;
    public string BrandName { get; set; } = string.Empty;
    public List<string>? PhotoUrl { get; set; } 
    public RespondPriceDto? Price { get; set; }
}