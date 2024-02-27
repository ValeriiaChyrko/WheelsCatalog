using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;

namespace WheelsCatalog.Persistence.Repositories.common;

public class GenericRepository<TEntity, TEntityModel> : IGenericRepository<TEntity>
    where TEntity : class
    where TEntityModel : class
{
    private readonly DbContext _context;
    private readonly IMapper _mapper;

    protected GenericRepository(DbContext context, IMapper mapper)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public virtual async Task<TEntity?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default)
        where TId : notnull
    {
        var entityModel = await _context.Set<TEntityModel>().FindAsync(new object[] { id }, cancellationToken);
        if (entityModel != null) _context.Entry(entityModel).State = EntityState.Detached;
        return entityModel != null ? _mapper.Map<TEntity>(entityModel) : null;
    }

    private async Task<List<TEntityModel>> GetEntityModelsAsync(
        int? pageNumber = null,
        int? pageSize = null,
        bool usePagination = false,
        bool useSorting = false,
        bool? isDescending = false,
        Expression<Func<TEntityModel, bool>>? predicate = null,
        Expression<Func<TEntityModel, object>>? sortExpression = null,
        Func<IQueryable<TEntityModel>, IQueryable<TEntityModel>>? include = null,
        Expression<Func<TEntityModel, object>>? navigationPropertyPath = null,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntityModel> query = _context.Set<TEntityModel>();

        if (predicate != null)
            query = query.Where(predicate);

        if (include != null)
        {
            query = include(query);
            if (navigationPropertyPath != null)
                query = query.Include(navigationPropertyPath);
        }

        if (useSorting && sortExpression != null)
        {
            query = isDescending == true ? query.OrderByDescending(sortExpression) : query.OrderBy(sortExpression);
        }
        
        if (usePagination && pageNumber.HasValue && pageSize.HasValue)
        {
            query = query
                .Skip((pageNumber.Value - 1) * pageSize.Value)
                .Take(pageSize.Value);
        }

        return await query.ToListAsync(cancellationToken);
    }
    
    private async Task<ICollection<TEntity>> BaseListAsync(
        int? pageNumber = null,
        int? pageSize = null,
        bool usePagination = false,
        bool useSorting = false,
        bool? isDescending = false,
        Expression<Func<TEntityModel, bool>>? predicate = null,
        Expression<Func<TEntityModel, object>>? sortExpression = null,
        Func<IQueryable<TEntityModel>, IQueryable<TEntityModel>>? include = null,
        Expression<Func<TEntityModel, object>>? navigationPropertyPath = null,
        CancellationToken cancellationToken = default)
    {
        var entityModels = await GetEntityModelsAsync(pageNumber, pageSize, usePagination,
            useSorting, isDescending, predicate, sortExpression, include, navigationPropertyPath, cancellationToken);
        return entityModels.Select(entityModel => _mapper.Map<TEntity>(entityModel)).ToList();
    }
    
    public virtual async Task<ICollection<TEntity>> ListAsync(CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(cancellationToken: cancellationToken);
    }
    
    public virtual async Task<ICollection<TEntity>> ListAsync(int pageNumber, int pageSize, 
        CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(pageNumber: pageNumber, pageSize: pageSize,
            usePagination: true, cancellationToken: cancellationToken);
    }
    
    protected async Task<ICollection<TEntity>> ListAsync(int pageNumber, int pageSize, 
        Expression<Func<TEntityModel, bool>>? predicate,
        CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(pageNumber: pageNumber, pageSize: pageSize, usePagination: true,
            predicate: predicate, cancellationToken: cancellationToken);
    }
    
    protected async Task<ICollection<TEntity>> ListAsync(int? pageNumber, int? pageSize, 
        bool? isDescending = false,
        Expression<Func<TEntityModel, object>>? sortExpression = null,
        Expression<Func<TEntityModel, bool>>? predicate = null, 
        CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(usePagination: true, pageNumber: pageNumber, pageSize: pageSize,
            useSorting: true, sortExpression:sortExpression, isDescending: isDescending,
            predicate: predicate, cancellationToken: cancellationToken);
    }
    
    protected async Task<ICollection<TEntity>> ListAsync(
        Expression<Func<TEntityModel, bool>>? predicate = null,
        CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(predicate: predicate, cancellationToken: cancellationToken);
    }
    
    protected async Task<ICollection<TEntity>> ListAsync( 
        bool? isDescending = false,
        Expression<Func<TEntityModel, object>>? sortExpression = null,
        Expression<Func<TEntityModel, bool>>? predicate = null,
        CancellationToken cancellationToken = default)
    {
        return await BaseListAsync(useSorting: true, sortExpression:sortExpression, isDescending: isDescending,
            predicate: predicate, cancellationToken: cancellationToken);
    }
    
    protected async Task<List<TEntityModel>> ListAsync(
        Func<IQueryable<TEntityModel>, IQueryable<TEntityModel>>? include = null,
        Expression<Func<TEntityModel, object>>? navigationPropertyPath = null,
        CancellationToken cancellationToken = default)
    {
        return await GetEntityModelsAsync(include: include, navigationPropertyPath: navigationPropertyPath, 
            cancellationToken: cancellationToken);
    }

    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntityModel>().CountAsync(cancellationToken);
    }

    protected async Task<int> CountAsync(Expression<Func<TEntityModel, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntityModel>().CountAsync(predicate, cancellationToken);
    }

    public virtual async Task<bool> AnyAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntityModel>().AnyAsync(cancellationToken);
    }

    public virtual TEntity Add(TEntity entity)
    {
        var mappedEntity = _mapper.Map<TEntityModel>(entity);
        var addedEntity = _context.Set<TEntityModel>().Add(mappedEntity).Entity;
        _context.SaveChanges();

        _context.Entry(addedEntity).State = EntityState.Detached;
        return _mapper.Map<TEntity>(addedEntity);
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        var mappedEntity = _mapper.Map<TEntityModel>(entity);
        _context.Set<TEntityModel>().Add(mappedEntity);
        await _context.SaveChangesAsync(cancellationToken);

        _context.Entry(mappedEntity).State = EntityState.Detached;
        return _mapper.Map<TEntity>(mappedEntity);
    }

    public virtual ICollection<TEntity> AddRange(ICollection<TEntity> entities)
    {
        var mappedEntities = entities.Select(entity => _mapper.Map<TEntityModel>(entity)).ToList();
        _context.Set<TEntityModel>().AddRange(mappedEntities);
        _context.SaveChanges();

        return entities;
    }

    public virtual async Task<int> AddRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        var mappedEntities = entities.Select(entity => _mapper.Map<TEntityModel>(entity)).ToList();
        _context.Set<TEntityModel>().AddRange(mappedEntities);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual void Delete(TEntity entity)
    {
        var entityModel = _mapper.Map<TEntityModel>(entity);
        _context.Set<TEntityModel>().Remove(entityModel);
    }

    public virtual async Task<int> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        var entityModel = _mapper.Map<TEntityModel>(entity);
        _context.Set<TEntityModel>().Remove(entityModel);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual void DeleteRange(ICollection<TEntity> entities)
    {
        var entityModels = entities.Select(entity => _mapper.Map<TEntityModel>(entity)).ToList();
        _context.Set<TEntityModel>().RemoveRange(entityModels);
    }

    public virtual async Task<int> DeleteRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        var entityModels = entities.Select(entity => _mapper.Map<TEntityModel>(entity)).ToList();
        _context.Set<TEntityModel>().RemoveRange(entityModels);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual void Update(TEntity entity)
    {
        var entityModel = _mapper.Map<TEntityModel>(entity);
        _context.Set<TEntityModel>().Update(entityModel);
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        var mappedEntity = _mapper.Map<TEntityModel>(entity);
        _context.Set<TEntityModel>().Update(mappedEntity);
        await _context.SaveChangesAsync(cancellationToken);
        return _mapper.Map<TEntity>(mappedEntity);
    }
}