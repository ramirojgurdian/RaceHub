using System.Text.Json;
using Api.Controllers;

namespace Api.Repositories;

public class JsonRaceEventRepository : IRaceEventRepository 
{
    private async Task<ICollection<RaceEvent>> ReadJsonFile()
    {
        var textFile = await File.ReadAllTextAsync("./Data/raceEvents.json");

        ICollection<RaceEvent> raceEvents = JsonSerializer.Deserialize<List<RaceEvent>>(textFile) 
                                            ?? throw new Exception("Failed to parse");
        return raceEvents;
    }

    public async Task<Result<ICollection<RaceEvent>>> GetAllEvents()
    {
        var raceEvents = await ReadJsonFile();
        return Result<ICollection<RaceEvent>>.Success(raceEvents);
    }


    public async Task<Result<RaceEvent>> AddEvent(RaceEvent raceEvent)
    {
        try
        {
            var raceEvents = await ReadJsonFile();
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

    public async Task<Result<ICollection<RaceEvent>>> GetEventsForSeries(string series)
    {
        var raceEvents = await ReadJsonFile();
       var result = raceEvents.Where(x => x.Series.Name == series).ToList();
       return Result<ICollection<RaceEvent>>.Success((ICollection<RaceEvent>)result);
    }
}