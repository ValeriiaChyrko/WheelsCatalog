using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

public class ColorEntityModel
{
    [Key] public Guid Id { get; set; }
    
    [Required] [MaxLength(255)] 
    public string Name { get; set; } = string.Empty;
    
    [Required] [MaxLength(127)] 
    public string HexCode { get; set; }  = string.Empty;
}