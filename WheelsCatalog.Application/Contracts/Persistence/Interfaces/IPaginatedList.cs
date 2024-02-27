namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces;

public interface IPaginatedList<TEntity> where TEntity : class
{
    IReadOnlyList<TEntity> Data { get; }
    IPageable Pagination { get; }
}