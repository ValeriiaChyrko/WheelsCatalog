namespace WheelsCatalog.Application.Contracts.Presentation;

public class CarFilteringParameters
{
    public double? EngineVolume { get; set; }
    
    public Guid? ModelId { get; set; }
    public string? PartialModelName { get; set; }
    
    public Guid? BrandId { get; set; }
    public string? PartialBrandName { get; set; }
    
    public Guid? ColorId { get; set; }
}