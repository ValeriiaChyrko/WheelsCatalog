namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestPriceDto
{
    public double Amount { get; set; }
    public DateTime? Date { get; set; }
    public Guid? CurrencyId { get; set; }
    public Guid? CarId { get; set; }
}