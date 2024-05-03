using Weatherstation.Data.Models;

namespace Weatherstation.UI.DataAccess.Interfaces;

public interface IEntryService
{
    /// <summary>
    /// Posts a new Entry to the API
    /// </summary>
    internal Task PostEntryAsync(Entry entry);
    
    /// <summary>
    /// Posts multiple entries to the database
    /// </summary>
    internal Task PostEntriesAsync(List<Entry> entries);
    
    /// <summary>
    /// Sends a request for all entries in the database
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync();
    
    /// <summary>
    /// Sends a request for all entries for a specific station
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(int stationId);
    
    /// <summary>
    /// Sends a request for all entries within a specific time frame
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to);
    
    /// <summary>
    /// Sends a request for all entries for a specific station within a specific time frame
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to);
}