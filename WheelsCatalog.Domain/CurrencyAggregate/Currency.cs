using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;

namespace WheelsCatalog.Domain.CurrencyAggregate;

public class Currency : AggregateRoot<CurrencyId>
{
    public string Acronym { get; private set; }
    public DateTime CreateDateTime { get; private set; }
    public DateTime UpdateDateTime { get; private set; }

    public Currency(CurrencyId id, string acronym, DateTime createDateTime, DateTime updateDateTime) : base(id)
    {
        Acronym = acronym;
        CreateDateTime = createDateTime;
        UpdateDateTime = updateDateTime;
    }
    
    public static Currency Create(string acronym)
    {
        var recordDateTime = DateTime.Now;
        
        return new Currency(CurrencyId.CreateUnique(), acronym, recordDateTime, recordDateTime);
    }
    
    public void Update(string acronym)
    {
        Acronym = acronym;
        UpdateDateTime = DateTime.Now;
    }

#pragma warning disable CS8618 
    public Currency() { }
#pragma warning restore CS8618 
}