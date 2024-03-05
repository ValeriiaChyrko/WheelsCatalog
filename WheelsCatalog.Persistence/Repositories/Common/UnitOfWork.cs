using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;

namespace WheelsCatalog.Persistence.Repositories.common;

public class UnitOfWork : IUnitOfWork
{
    private readonly WheelsCatalogDbContext _context;
    private readonly IMapper _mapper;
    private IDbContextTransaction? _transaction;

    private IBrandRepository? _brandRepository;
    private ICarPhotoRepository? _carPhotoRepository;
    private ICarRepository? _carRepository;
    private IColorRepository? _colorRepository;
    private ICurrencyRepository? _currencyRepository;
    private IModelRepository? _modelRepository;
    private IPriceHistoryRepository? _priceHistoryRepository;

    public UnitOfWork(WheelsCatalogDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _transaction = null;
    }
    
    public IBrandRepository BrandRepository
    {
        get { return _brandRepository ??= new BrandRepository(_context, _mapper); }
    }
    
    public ICarPhotoRepository CarPhotoRepository
    {
        get { return _carPhotoRepository ??= new CarPhotoRepository(_context, _mapper); }
    }
    
    public ICarRepository CarRepository
    {
        get { return _carRepository ??= new CarRepository(_context, _mapper); }
    }
    
    public IColorRepository ColorRepository
    {
        get { return _colorRepository ??= new ColorRepository(_context, _mapper); }
    }
    
    public ICurrencyRepository CurrencyRepository
    {
        get { return _currencyRepository ??= new CurrencyRepository(_context, _mapper); }
    }
    
    public IModelRepository ModelRepository
    {
        get { return _modelRepository ??= new ModelRepository(_context, _mapper); }
    }
    
    public IPriceHistoryRepository PriceHistoryRepository
    {
        get { return _priceHistoryRepository ??= new PriceHistoryRepository(_context, _mapper); }
    }

    public void Dispose()
    {
        _context.DisposeAsync();
    }

    public bool HasActiveTransaction => _transaction != null;

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public IDbContextTransaction? GetCurrentTransaction()
    {
        return _transaction;
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        if (_transaction != null)
            throw new InvalidOperationException("Transaction is already active.");

        _transaction = await _context.Database.BeginTransactionAsync();

        return _transaction;
    }

    public async Task CommitAsync(IDbContextTransaction transaction, CancellationToken cancellationToken)
    {
        if (transaction == null)
            throw new ArgumentNullException(nameof(transaction));

        if (transaction != _transaction)
            throw new InvalidOperationException("Transaction is not current.");

        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken);
            throw new OperationCanceledException(ex.Message);
        }
        finally
        {
            _transaction.Dispose();
            _transaction = null;
        }
    }
}