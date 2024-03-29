﻿namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestPriceHistoryDto
{
    public double Amount { get; init; }
    public DateTime? Date { get; init; }
    public Guid? CurrencyId { get; init; }
    public Guid? CarId { get; init; }
}