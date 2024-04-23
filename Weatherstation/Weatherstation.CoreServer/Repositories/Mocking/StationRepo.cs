using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Repositories.Mocking;

public class StationRepo: IStationRepo
{
    private List<Station> _stations = new(); 
    
    public Task AddStationAsync(Station station)
    {
        _stations.Add(station);
        return Task.CompletedTask;
    }

    public Task<List<Station>> GetAllStationsAsync()
    {
        return Task.FromResult(_stations);
    }

    public Task<Station> GetStationAsync(int id)
    {
        return Task.FromResult(_stations.FirstOrDefault(x => x.Id == id));
    }

    public Task UpdateStationAsync(Station station)
    {
        var index = _stations.FindIndex(x => x.Id == station.Id);
        _stations[index] = station;
        return Task.CompletedTask;
    }

    public Task DeleteStationAsync(int id)
    {
        _stations.Remove(_stations.FirstOrDefault(x => x.Id == id));
        return Task.CompletedTask;
    }
}