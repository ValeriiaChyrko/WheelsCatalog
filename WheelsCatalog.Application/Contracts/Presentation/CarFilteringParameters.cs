using WheelsCatalog.Application.Contracts.Persistence.Interfaces;

namespace WheelsCatalog.Application.Contracts.Presentation;

public class CarFilteringParameters : IPageable, ISortable
{
    public double? MinEngineVolume { get; set; }
    public double? MaxEngineVolume { get; set; }
    
    public Guid? ModelId { get; set; }
    public string? PartialModelName { get; set; }
    
    public Guid? BrandId { get; set; }
    public string? PartialBrandName { get; set; }
    
    public Guid? ColorId { get; set; }
    
    public int? Page { get; set; }
    public int? Limit { get; set; }
    public bool IsDescending { get; set; }
    public string? SortPropertyName { get; set; }
}