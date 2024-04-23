using Microsoft.EntityFrameworkCore;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Context;

public class WeatherDataContext(DbContextOptions<WeatherDataContext> options) : DbContext(options)
{
    public DbSet<Entry> Entries { get; set; }
    public DbSet<Station> Stations { get; set; }
}