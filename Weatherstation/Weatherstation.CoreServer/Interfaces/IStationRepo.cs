using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Interfaces;

internal interface IStationRepo
{
    /// <summary>
    /// Adds a station to the database
    /// </summary>
    internal Task AddStationAsync(Station station);
    
    /// <summary>
    /// Returns all stations in the database
    /// </summary>
    internal Task<List<Station>> GetAllStationsAsync();
    
    /// <summary>
    /// Returns a specific station
    /// </summary>
    internal Task<Station> GetStationAsync(int id);
    
    /// <summary>
    /// Updates a station in the database
    /// </summary>
    internal Task UpdateStationAsync(Station station);
    
    /// <summary>
    /// Deletes a station in the database
    /// </summary>
    internal Task DeleteStationAsync(int id);
}