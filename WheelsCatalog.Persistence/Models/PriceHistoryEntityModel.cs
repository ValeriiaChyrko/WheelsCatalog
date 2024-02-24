using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class PriceHistoryEntityModel
{
    [Key] public Guid Id { get; set; }

    [Required] public double Price { get; set; }

    [Required] public DateTime StartDate { get; set; }

    [Required] public Guid CurrencyId { get; set; }
    public CurrencyEntityModel Currency { get; set; } = null!;

    [Required] public Guid CarId { get; set; }
    public CarEntityModel Car { get; set; } = null!;

    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }
}