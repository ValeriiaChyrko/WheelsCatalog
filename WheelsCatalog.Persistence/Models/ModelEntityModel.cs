using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class ModelEntityModel
{
    [Key] public Guid Id { get; set; }

    [Required] [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(512)]
    public string? Description { get; set; }

    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }

    [Required]
    public Guid BrandId { get; set; }
    public BrandEntityModel Brand { get; set; } = null!;
    
}