namespace WheelsCatalog.Persistence.Mappers.Common;

public interface IEntityMapper<TEntity, TModel>
{
    TModel MapToModel(TEntity entity);
    TEntity MapToEntity(TModel model);
}