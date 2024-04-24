using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Mocking;

public class EntryGenerator
{
    public List<Entry> Generate(int count)
    {
        var entries = new List<Entry>();
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            entries.Add(new Entry
            {
                Timestamp = DateTime.Now.AddMinutes(-i),
                Value  = random.Next(-20, 40),
                StationId = 1 ,
                
            });
        }
        return entries;
    }
}