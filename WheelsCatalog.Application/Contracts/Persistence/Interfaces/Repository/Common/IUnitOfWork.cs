using Microsoft.EntityFrameworkCore.Storage;

namespace WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    bool HasActiveTransaction { get; }
    IDbContextTransaction? GetCurrentTransaction();
    Task<IDbContextTransaction> BeginTransactionAsync();
    Task CommitAsync(IDbContextTransaction transaction);
    
    IBrandRepository BrandRepository { get; }
    ICarPhotoRepository CarPhotoRepository { get; }
    ICarRepository CarRepository { get; }
    IColorRepository ColorRepository { get; }
    ICurrencyRepository CurrencyRepository { get; }
    IModelRepository ModelRepository { get; }
    IPriceHistoryRepository PriceHistoryRepository { get; }
}