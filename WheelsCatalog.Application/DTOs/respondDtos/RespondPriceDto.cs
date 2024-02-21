namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondPriceDto
{
    public Guid Id { get; set; } 
    public double Amount { get; set; }
    public DateTime? Date { get; set; }
    public string CurrencyAcronym { get; set; } = string.Empty;
}