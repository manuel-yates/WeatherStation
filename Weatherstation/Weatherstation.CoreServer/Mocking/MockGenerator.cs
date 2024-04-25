using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Mocking;

public class MockGenerator
{
    StationGenerator stationGenerator = new();
    public static List<Station> Stations = new();
    public static List<Entry> Entries = new();

    public async Task GenerateMockData()
    {
        Stations = stationGenerator.Generate(10);
        foreach (var station in Stations)
        {
            Entries.AddRange(new EntryGenerator().Generate(100, station));
        }
    }
}