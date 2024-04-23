using System.Dynamic;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Interfaces;

internal interface IEntryRepo
{
    /// <summary>
    /// Adds an entry to the database
    /// </summary>
    internal Task AddEntryAsync(Entry entry);
    
    /// <summary>
    /// Adds multiple entries to the database
    /// </summary>
    internal Task AddEntriesAsync(List<Entry> entries);
    
    /// <summary>
    /// Returns all entries in the database
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync();
    
    /// <summary>
    /// Returns all entries for a specific station
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(int stationId);
    
    /// <summary>
    /// Returns all entries within a specific time frame
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(DateTime from, DateTime to);
    
    /// <summary>
    /// Returns all entries for a specific station within a specific time frame
    /// </summary>
    internal Task<List<Entry>> GetAllEntriesAsync(int stationId, DateTime from, DateTime to);
}