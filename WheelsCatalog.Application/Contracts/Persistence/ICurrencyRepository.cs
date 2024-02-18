using WheelsCatalog.Application.contracts.persistence.common;
using WheelsCatalog.Domain.PriceHistoryAggregate.Entities;

namespace WheelsCatalog.Application.contracts.persistence;

public interface ICurrencyRepository : IGenericRepository<CurrencyEntity>
{
    
}