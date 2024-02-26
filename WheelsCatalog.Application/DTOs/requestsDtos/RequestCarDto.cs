namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestCarDto
{
    public double EngineVolume { get; init; }
    public string? Description { get; init; }
    public Guid? ModelId { get; init; }
    public Guid? ColorId { get; init; }
}