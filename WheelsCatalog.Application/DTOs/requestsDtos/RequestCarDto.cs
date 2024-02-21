namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestCarDto
{
    public int EngineVolume { get; set; }
    public string? Description { get; set; }
    public Guid? ModelId { get; set; }
    public Guid? ColorId { get; set; }
}