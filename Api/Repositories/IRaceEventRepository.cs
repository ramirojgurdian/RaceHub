namespace Api.Controllers;

public interface IRaceEventRepository
{
    Task<Result<ICollection<RaceEvent>>> GetAllEvents();
    Task<Result<RaceEvent>> AddEvent(RaceEvent raceEvent);
    Task<Result<ICollection<RaceEvent>>> GetEventsForSeries(string series);
}