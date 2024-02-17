using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

public class CurrencyEntityModel
{
    [Key] public Guid Id { get; set; }
    
    [Required] [MaxLength(127)] 
    public string Acronym { get; set; } = string.Empty;
    
    public ICollection<PriceHistoryEntityModel> Models { get; set; } = new List<PriceHistoryEntityModel>();
}