using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.PriceHistory.ValueObjects;

namespace WheelsCatalog.Domain.PriceHistory.Entities;

public class CurrencyEntity : Entity<CurrencyId>
{
    public string Acronym { get; }

    public CurrencyEntity(CurrencyId id, string acronym) : base(id)
    {
        Acronym = acronym;
    }
    
    public static CurrencyEntity Create(string acronym)
    {
        return new CurrencyEntity(CurrencyId.CreateUnique(), acronym);
    }
}