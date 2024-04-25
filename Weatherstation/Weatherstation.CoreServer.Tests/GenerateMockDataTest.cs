using Weatherstation.CoreServer.Mocking;
using NUnit.Framework.Legacy;

namespace Weatherstation.CoreServer.Tests;

public class Tests
{
    [Test]
    public async Task GenerateMockData_ShouldGenerateExpectedAmountOfData()
    {
        // Arrange
        var mockGenerator = new MockGenerator();
        var expectedStationCount = 10;
        var expectedEntryCountPerStation = 100;

        // Act
        await mockGenerator.GenerateMockData();

        
        // Assert
        ClassicAssert.AreEqual(expectedStationCount, MockGenerator.Stations.Count);
        foreach (var station in MockGenerator.Stations)
        {
            var entriesForStation = MockGenerator.Entries.FindAll(entry => entry.Station == station);
            ClassicAssert.AreEqual(expectedEntryCountPerStation, entriesForStation.Count);
        }
    }
    
    [Test]
    public async Task GenerateMockData_ShouldGenerateCorrectValues()
    {
        // Arrange
        var mockGenerator = new MockGenerator();

        // Act
        await mockGenerator.GenerateMockData();

        // Assert
        foreach (var entry in MockGenerator.Entries)
        {
            // Check if the value is within the expected range
            ClassicAssert.IsTrue(entry.Value >= -20 && entry.Value <= 40, "Entry value is out of range");

            // Check if the timestamp is not in the future
            ClassicAssert.IsTrue(entry.Timestamp <= DateTime.Now, "Entry timestamp is in the future");

            // Check if the station is not null
            ClassicAssert.IsNotNull(entry.Station, "Entry station is null");
        }
    }
    
    [Test]
    public async Task GenerateMockData_ShouldGenerateCorrectStations()
    {
        // Arrange
        var mockGenerator = new MockGenerator();

        // Act
        await mockGenerator.GenerateMockData();

        // Assert
        foreach (var station in MockGenerator.Stations)
        {
            // Check if the station name is not null or empty
            ClassicAssert.IsNotEmpty(station.Name, "Station name is null or empty");

            // Check if the longitude is within the expected range
            ClassicAssert.IsTrue(int.Parse(station.Longitude) >= -180 && int.Parse(station.Longitude) <= 180, "Station longitude is out of range");

            // Check if the latitude is within the expected range
            ClassicAssert.IsTrue(int.Parse(station.Latitude) >= -90 && int.Parse(station.Latitude) <= 90, "Station latitude is out of range");
        }
    }
}