using System.Text.Json;

namespace Api.Controllers;

public class JsonRaceEventRepository : IRaceEventRepository 
{
    public async Task<ICollection<RaceEvent>> GetAllEvents()
    {
        var textFile = await File.ReadAllTextAsync("/Data/raceEvents.json");

        ICollection<RaceEvent> raceEvents = JsonSerializer.Deserialize<List<RaceEvent>>(textFile) 
                                            ?? throw new Exception("Failed to parse");

        return raceEvents;
    }
}