namespace WheelsCatalog.Application.Contracts.Presentation;

public class PriceFilteringParameters
{
    public DateTime? Date { get; init; }
    public int? MinPrice { get; init; }
    public int? MaxPrice { get; init; }
}