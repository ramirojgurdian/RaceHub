namespace Api.Controllers;

public class RaceEvent
{
    public string EventName { get; set; } = string.Empty;
    public Series Series { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public Track Track { get; set; } = new();
}