using System.Text.Json;
using Api.Controllers;

namespace Api.Repositories;

public class JsonRaceEventRepository : IRaceEventRepository 
{
    public async Task<Result<ICollection<RaceEvent>>> GetAllEvents()
    {
        var textFile = await File.ReadAllTextAsync("./Data/raceEvents.json");

        ICollection<RaceEvent> raceEvents = JsonSerializer.Deserialize<List<RaceEvent>>(textFile) 
                                            ?? throw new Exception("Failed to parse");

        return Result<ICollection<RaceEvent>>.Success(raceEvents);
    }


    public async Task<Result<RaceEvent>> AddEvent(RaceEvent raceEvent)
    {
        try
        {
            var textFile = await File.ReadAllTextAsync("./Data/raceEvents.json");
            ICollection<RaceEvent> raceEvents = JsonSerializer.Deserialize<List<RaceEvent>>(textFile) 
                                                ?? throw new Exception("Failed to parse");
            raceEvents.Add(raceEvent); 
            var json = JsonSerializer.Serialize(raceEvents);
            await File.WriteAllTextAsync("./Data/raceEvents.json", json);
            return Result<RaceEvent>.Success(raceEvent);
        }
        catch (Exception ex)
        {
            return Result<RaceEvent>.Failed(ex.Message);
        }
    }
        
}