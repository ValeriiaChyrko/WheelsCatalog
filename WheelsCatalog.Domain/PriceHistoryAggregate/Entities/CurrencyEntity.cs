using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Domain.PriceHistoryAggregate.Entities;

public class CurrencyEntity : Entity<CurrencyId>
{
    public string Acronym { get; private set; }

    public CurrencyEntity(CurrencyId id, string acronym) : base(id)
    {
        Acronym = acronym;
    }
    
    public static CurrencyEntity Create(string acronym)
    {
        return new CurrencyEntity(CurrencyId.CreateUnique(), acronym);
    }

#pragma warning disable CS8618 
    public CurrencyEntity() { }
#pragma warning restore CS8618 
}