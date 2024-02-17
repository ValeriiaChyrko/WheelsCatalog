using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

public class CarPhotoEntityModel
{
    [Key] public Guid Id { get; set; }
    
    [Required] [MaxLength(512)] 
    public string PhotoUrl { get; set; } = string.Empty;
    
    [Required]
    public Guid CarId { get; set; }
    public CarEntityModel Car { get; set; } = null!;
}