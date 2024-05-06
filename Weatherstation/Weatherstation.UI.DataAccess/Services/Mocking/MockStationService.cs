using Microsoft.Extensions.Logging;
using Weatherstation.Data.Models;
using Weatherstation.UI.DataAccess.Interfaces;

namespace Weatherstation.UI.DataAccess.Services.Mocking;

public class MockStationService(ILogger<MockServiceBase> logger) : MockServiceBase(logger), IStationService
{
    private List<Station> _stations = new List<Station>();

    public Task AddStationAsync(Station station)
    {
        _stations.Add(station);
        return Task.CompletedTask;
    }

    public Task<List<Station>> GetAllStationsAsync()
    {
        return Task.FromResult<List<Station>>(_stations);
    }

    public Task<Station> GetStationAsync(int id)
    {
        var station = _stations.FirstOrDefault(x => x.Id == id);
        return Task.FromResult<Station>(station);
    }

    public Task UpdateStationAsync(Station station)
    {
        throw new NotImplementedException();
    }

    public Task DeleteStationAsync(int id)
    {
        throw new NotImplementedException();
    }
}