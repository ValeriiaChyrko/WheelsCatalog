using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class CarEntityModel
{
    [Key] public Guid Id { get; set; }

    [Required] public double EngineVolume { get; set; }

    [MaxLength(512)] public string? Description { get; set; }

    [Required] public Guid ColorId { get; set; }
    public ColorEntityModel Color { get; set; } = null!;

    [Required] public Guid ModelId { get; set; }
    public ModelEntityModel Model { get; set; } = null!;

    public ICollection<CarPhotoEntityModel>? Photos { get; set; }
    public ICollection<PriceHistoryEntityModel>? PriceHistories { get; set; }

    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }
}