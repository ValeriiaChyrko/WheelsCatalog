using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class BrandEntityModel
{
    [Key] public Guid Id { get; set; }

    [Required] [MaxLength(255)] public string Name { get; set; } = string.Empty;

    [Required] [MaxLength(512)] public string LogoUrl { get; set; } = string.Empty;

    [MaxLength(512)] public string? Description { get; set; }

    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }

    public ICollection<ModelEntityModel> Models { get; set; } = new List<ModelEntityModel>();
}