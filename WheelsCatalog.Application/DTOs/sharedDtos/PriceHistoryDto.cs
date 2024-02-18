namespace WheelsCatalog.Application.dtos.sharedDtos;

public class PriceHistoryDto
{
    public double Price { get; set; }
    public DateTime StartDate { get; set; }
    public int CarId { get; set; }
    public int CurrencyId { get; set; }
}