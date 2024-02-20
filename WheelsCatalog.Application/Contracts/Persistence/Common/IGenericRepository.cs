namespace WheelsCatalog.Application.Contracts.Persistence.Common;

public interface IGenericRepository<TEntity> : IReadRepositoryBase<TEntity> where TEntity : class
{
    TEntity Add(TEntity entity);
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    ICollection<TEntity> AddRange(ICollection<TEntity> entities);
    Task<int> AddRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default);
    void Delete(TEntity entity);
    Task<int> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    void DeleteRange(ICollection<TEntity> entities);
    Task<int> DeleteRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default);
    void Update(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
}