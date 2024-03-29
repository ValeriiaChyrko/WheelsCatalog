﻿namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;

public interface IReadRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;
    Task<ICollection<TEntity>> ListAsync(CancellationToken cancellationToken = default);
    Task<ICollection<TEntity>> ListAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<int> CountAsync(CancellationToken cancellationToken = default);
    Task<bool> AnyAsync(CancellationToken cancellationToken = default);
}