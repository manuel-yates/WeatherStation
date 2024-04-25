using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Mocking;

public class StationGenerator
{
    public List<Station> Generate(int count)
    {
        var stations = new List<Station>();
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            stations.Add(new Station
            {
                Name = $"Station {i + 1}",
                Longitude = random.Next(-180, 180).ToString(),
                Latitude = random.Next(-90, 90).ToString(),
            });
        }
        return stations;
    }
}