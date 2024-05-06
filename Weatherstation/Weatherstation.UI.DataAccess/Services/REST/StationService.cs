using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using Weatherstation.Data.Models;
using Weatherstation.UI.DataAccess.Interfaces;

namespace Weatherstation.UI.DataAccess.Services.REST;

public class StationService(ILogger<StationService> logger) : RESTServiceBase<StationService>(logger), IStationService
{
    public async Task AddStationAsync(Station station)
    {
        await _client.PostAsJsonAsync("api/stations", station);
    }

    public async Task<List<Station>> GetAllStationsAsync()
    {
        return await _client.GetFromJsonAsync<List<Station>>("api/stations");
    }

    public async Task<Station> GetStationAsync(int id)
    {
        return await _client.GetFromJsonAsync<Station>($"api/stations/{id}");
    }

    public async Task UpdateStationAsync(Station station)
    {
        await _client.PutAsJsonAsync($"api/stations/{station.Id}", station);
    }

    public async Task DeleteStationAsync(int id)
    {
        await _client.DeleteAsync($"api/stations/{id}");
    }
}