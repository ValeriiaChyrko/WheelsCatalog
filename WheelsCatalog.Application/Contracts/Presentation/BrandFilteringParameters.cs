using WheelsCatalog.Application.Contracts.Persistence.Interfaces;

namespace WheelsCatalog.Application.Contracts.Presentation;

public class BrandFilteringParameters : IPageable, ISortable
{
    public string? PartialName { get; set; }
    
    public int? Page { get; set; }
    public int? Limit { get; set; }
    
    public bool IsDescending { get; set; }
    public string? SortPropertyName { get; set; }
}