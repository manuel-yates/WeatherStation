using System.ComponentModel.DataAnnotations;
using ValueType = Weatherstation.Data.Enums.ValueType;

namespace Weatherstation.Data.Models;

public record Entry
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public double Value { get; set; }
    
    [Required]
    public ValueType ValueType { get; set; }
    
    [Required]
    public DateTime Timestamp { get; set; }
    public Station Station { get; set; }
    
}