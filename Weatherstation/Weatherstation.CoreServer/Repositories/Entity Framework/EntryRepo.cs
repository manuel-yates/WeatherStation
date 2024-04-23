using Microsoft.EntityFrameworkCore;
using Weatherstation.CoreServer.Context;
using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Repositories.Entity_Framework;

public class EntryRepo(WeatherDataContext context) : IEntryRepo
{
    public async Task AddEntryAsync(Entry entry)
    {
        await context.Entries.AddAsync(entry);
        await context.SaveChangesAsync();
    }

    public async Task AddEntriesAsync(List<Entry> entries)
    {
        await context.Entries.AddRangeAsync(entries);
        await context.SaveChangesAsync();
    }

    public Task<List<Entry>> GetAllEntriesAsync()
    {
        return context.Entries.ToListAsync();
    }

    public async Task<List<Entry>> GetAllEntriesAsync(int stationId)
    {
        return await context.Entries.Where(x => x.Station.Id == stationId).ToListAsync();
    }

    public async Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to)
    {
        return await context.Entries.Where(x => x.Timestamp > from && x.Timestamp <= to).ToListAsync();
    }

    public async Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to)
    {
        return await context.Entries.Where(x => x.Timestamp > from && x.Timestamp <= to).Where(x => x.Station.Id == stationId).ToListAsync();
    }
}