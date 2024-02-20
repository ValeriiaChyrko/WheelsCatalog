using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class CurrencyEntityModel
{
    [Key] public Guid Id { get; set; }
    
    [Required] [MaxLength(127)] 
    public string Acronym { get; set; } = string.Empty;
    
    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }
    
    public ICollection<PriceHistoryEntityModel> Models { get; set; } = new List<PriceHistoryEntityModel>();
}