using System.ComponentModel.DataAnnotations;

namespace Weatherstation.Data.Models;

public record Entry
{
    [Key]
    public int Id { get; set; }
    public double Value { get; set; }
    public DateTime Timestamp { get; set; }
    public Station Station { get; set; }
}