using WheelsCatalog.Application.Contracts.Persistence.Interfaces;

namespace WheelsCatalog.Application.Contracts.Persistence;

public class Pageable : IPageable
{
    public int? Page { get; set; }
    public int? Limit { get; set; }

    public Pageable(int? page, int? limit)
    {
        Page = page;
        Limit = limit;
    }
}