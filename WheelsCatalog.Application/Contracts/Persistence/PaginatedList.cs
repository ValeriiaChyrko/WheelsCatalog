using WheelsCatalog.Application.Contracts.Persistence.Interfaces;

namespace WheelsCatalog.Application.Contracts.Persistence;

public class PaginatedList<TEntity> : IPaginatedList<TEntity> where TEntity : class
{
    public PaginatedList(IReadOnlyList<TEntity> data, int page, int limit)
    {
        Data = data;
        Pagination = new Pageable(page, limit);
    }

    public IReadOnlyList<TEntity> Data { get; }
    public IPageable Pagination { get; }
}
