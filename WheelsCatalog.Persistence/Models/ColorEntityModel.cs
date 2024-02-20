using System.ComponentModel.DataAnnotations;

namespace WheelsCatalog.Persistence.Models;

internal class ColorEntityModel
{
    [Key] public Guid Id { get; set; }
    
    [Required] [MaxLength(255)] 
    public string Name { get; set; } = string.Empty;
    
    [Required] [MaxLength(127)] 
    public string HexCode { get; set; }  = string.Empty;
    
    [Required] public DateTime CreateDateTime { get; set; }

    [Required] public DateTime UpdateDateTime { get; set; }
}