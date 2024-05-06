using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using Weatherstation.Data.Models;
using Weatherstation.UI.DataAccess.Interfaces;

namespace Weatherstation.UI.DataAccess.Services.REST;

public class EntryService(ILogger<EntryService> logger) : RESTServiceBase<EntryService>(logger), IEntryService
{
    public async Task PostEntryAsync(Entry entry)
    {
        await _client.PostAsJsonAsync("api/entries", entry);
    }

    public async Task PostEntriesAsync(List<Entry> entries)
    {
        await _client.PostAsJsonAsync("api/entries/list", entries);
    }

    public async Task<List<Entry>> GetAllEntriesAsync()
    {
        return await _client.GetFromJsonAsync<List<Entry>>("api/entries");
    }

    public async Task<List<Entry>> GetAllEntriesAsync(int stationId)
    {
        return await _client.GetFromJsonAsync<List<Entry>>("api/entries/station/{stationId}");
    }

    public async Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to)
    {
        return await _client.GetFromJsonAsync<List<Entry>>("api/entries/{from}/{to}");
    }

    public async Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to)
    {
        return await _client.GetFromJsonAsync<List<Entry>>("api/entries/station/{stationId}/{from}/{to}");
    }
}