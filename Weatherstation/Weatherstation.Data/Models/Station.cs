using System.ComponentModel.DataAnnotations;

namespace Weatherstation.Data.Models;

public class Station
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Longitude { get; set; }
    
    public string Latitude { get; set; }
}