using Microsoft.EntityFrameworkCore;
using Weatherstation.CoreServer.Context;
using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Repositories.Entity_Framework;

public class StationRepo(WeatherDataContext context) : IStationRepo
{
    public async Task AddStationAsync(Station station)
    {
        await context.Stations.AddAsync(station);
        await context.SaveChangesAsync();
    }

    public async Task<List<Station>> GetAllStationsAsync()
    {
        return await context.Stations.ToListAsync();
    }

    public async Task<Station> GetStationAsync(int id)
    {
        return await context.Stations.FindAsync(id);
    }

    public async Task UpdateStationAsync(Station station)
    {
        context.Stations.Update(station);
        await context.SaveChangesAsync();
    }

    public async Task DeleteStationAsync(int id)
    {
        context.Stations.Remove(context.Stations.Find(id));
        await context.SaveChangesAsync();
    }
}