namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondCarDtoDetails
{
    public Guid Id { get; set; } 
    public int EngineVolume { get; set; }
    public string? Description { get; set; }
    public string ModelName { get; set; } = string.Empty;
    public string ColorName { get; set; } = string.Empty;
    public IReadOnlyList<string>? PhotoUrl { get; set; }
}