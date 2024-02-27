namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces;

public interface ISortable
{
    bool IsDescending { get; set; }
    string? SortPropertyName { get; set; }
}