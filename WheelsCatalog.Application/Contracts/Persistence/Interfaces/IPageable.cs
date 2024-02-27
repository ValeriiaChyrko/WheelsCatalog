namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces;

public interface IPageable
{
    public int? Page { get; set; }
    public int? Limit { get; set; }
}