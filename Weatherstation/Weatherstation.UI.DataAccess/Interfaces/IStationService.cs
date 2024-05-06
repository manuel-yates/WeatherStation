using Weatherstation.Data.Models;

namespace Weatherstation.UI.DataAccess.Interfaces;

public interface IStationService
{
    /// <summary>
    /// Posts a new station to the API
    /// </summary>
    internal Task AddStationAsync(Station station);
    
    /// <summary>
    /// Sends a request for all stations to the API
    /// </summary>
    internal Task<List<Station>> GetAllStationsAsync();
    
    /// <summary>
    /// Sends a request for a specific station to the API
    /// </summary>
    internal Task<Station> GetStationAsync(int id);
    
    /// <summary>
    /// Sends a request to Update a station to the API
    /// </summary>
    internal Task UpdateStationAsync(Station station);
    
    /// <summary>
    /// Sends a request to Delete a station to the API
    /// </summary>
    internal Task DeleteStationAsync(int id);
}