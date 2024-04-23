using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Repositories.Mocking;

public class EntryRepo : IEntryRepo
{
    private List<Entry> _entries = new();
    
    public Task AddEntryAsync(Entry entry)
    {
        _entries.Add(entry);
        return Task.CompletedTask;
    }

    public Task AddEntriesAsync(List<Entry> entries)
    {
        _entries.AddRange(entries);
        return Task.CompletedTask;
    }

    public Task<List<Entry>> GetAllEntriesAsync()
    {
        return Task.FromResult(_entries);
    }

    public Task<List<Entry>> GetAllEntriesAsync(int stationId)
    {
        return Task.FromResult(_entries.Where(x => x.Station.Id == stationId).ToList());
    }

    public Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to)
    {
        return Task.FromResult(_entries.Where(x => x.Timestamp > from && x.Timestamp <= to).ToList());
    }

    public Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to)
    {
        return Task.FromResult(_entries.Where(x => x.Timestamp > from && x.Timestamp <= to).Where(x => x.Station.Id == stationId).ToList());
    }
}