using Microsoft.Extensions.Logging;
using Weatherstation.Data.Models;
using Weatherstation.UI.DataAccess.Interfaces;

namespace Weatherstation.UI.DataAccess.Services.Mocking;

public class MockEntryService(ILogger<MockServiceBase> logger) : MockServiceBase(logger), IEntryService
{
    public Task PostEntryAsync(Entry entry)
    {
        throw new NotImplementedException();
    }

    public Task PostEntriesAsync(List<Entry> entries)
    {
        throw new NotImplementedException();
    }

    public Task<List<Entry>> GetAllEntriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Entry>> GetAllEntriesAsync(int stationId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }
}