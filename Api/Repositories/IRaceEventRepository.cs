namespace Api.Controllers;

public interface IRaceEventRepository
{
    Task<ICollection<RaceEvent>> GetAllEvents();
}