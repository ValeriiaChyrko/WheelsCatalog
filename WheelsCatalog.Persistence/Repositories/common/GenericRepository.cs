using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Application.Contracts.Persistence.Common;

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

    protected async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var entityModels = await _context.Set<TEntityModel>().ToListAsync(cancellationToken);
        return entityModels
            .Select(entityModel => _mapper.Map<TEntity>(entityModel))
            .Where(predicate.Compile())
            .ToList();
    }
    
    protected async Task<ICollection<TEntity>> ListAsync(
        Func<IQueryable<TEntityModel>, IQueryable<TEntityModel>>? include = null,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntityModel> query = _context.Set<TEntityModel>();
        if (include != null) query = include(query);

        var entityModels = await query
            .ToListAsync(cancellationToken);

        return entityModels
            .Select(entityModel => _mapper.Map<TEntity>(entityModel))
            .ToList();
    }

    public virtual async Task<ICollection<TEntity>> ListAsync(CancellationToken cancellationToken = default)
    {
        var entityModels = await _context.Set<TEntityModel>().ToListAsync(cancellationToken);
        return entityModels.Select(entityModel => _mapper.Map<TEntity>(entityModel)).ToList();
    }

    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntityModel>().CountAsync(cancellationToken);
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