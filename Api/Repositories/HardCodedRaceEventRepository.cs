namespace Api.Controllers;

public class HardCodedRaceEventRepository : IRaceEventRepository
{
    public Task<Result<ICollection<RaceEvent>>> GetAllEvents()
    {
        var result = new List<RaceEvent>();
        // Round 1: Australian Grand Prix (Local: 15:00 UTC+11)
        result.Add(new RaceEvent { EventName = "Australian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 3, 8, 4, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Australia", Name = "Albert Park Grand Prix Circuit" } });

        // Round 2: Chinese Grand Prix (Local: 15:00 UTC+8)
        result.Add(new RaceEvent { EventName = "Chinese Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 3, 15, 7, 0, 0, TimeSpan.Zero), Track = new Track { Country = "China", Name = "Shanghai International Circuit" } });

        // Round 3: Japanese Grand Prix (Local: 14:00 UTC+9)
        result.Add(new RaceEvent { EventName = "Japanese Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 3, 29, 5, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Japan", Name = "Suzuka International Racing Course" } });

        // Round 4: Miami Grand Prix (Local: 16:00 UTC-4)
        result.Add(new RaceEvent { EventName = "Miami Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 5, 3, 20, 0, 0, TimeSpan.Zero), Track = new Track { Country = "United States", Name = "Miami International Autodrome" } });

        // Round 5: Canadian Grand Prix (Local: 16:00 UTC-4)
        result.Add(new RaceEvent { EventName = "Canadian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 5, 24, 20, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Canada", Name = "Circuit Gilles-Villeneuve" } });

        // Round 6: Monaco Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Monaco Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 6, 7, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Monaco", Name = "Circuit de Monaco" } });

        // Round 7: Barcelona-Catalunya Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Barcelona-Catalunya Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 6, 14, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Spain", Name = "Circuit de Barcelona-Catalunya" } });

        // Round 8: Austrian Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Austrian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 6, 28, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Austria", Name = "Red Bull Ring" } });

        // Round 9: British Grand Prix (Local: 15:00 UTC+1)
        result.Add(new RaceEvent { EventName = "British Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 7, 5, 14, 0, 0, TimeSpan.Zero), Track = new Track { Country = "United Kingdom", Name = "Silverstone Circuit" } });

        // Round 10: Belgian Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Belgian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 7, 19, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Belgium", Name = "Circuit de Spa-Francorchamps" } });

        // Round 11: Hungarian Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Hungarian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 7, 26, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Hungary", Name = "Hungaroring" } });

        // Round 12: Dutch Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Dutch Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 8, 23, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Netherlands", Name = "Circuit Zandvoort" } });

        // Round 13: Italian Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Italian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 9, 6, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Italy", Name = "Autodromo Nazionale Monza" } });

        // Round 14: Spanish Grand Prix (Local: 15:00 UTC+2)
        result.Add(new RaceEvent { EventName = "Spanish Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 9, 13, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Spain", Name = "Madrid Street Circuit" } });

        // Round 15: Azerbaijan Grand Prix (Saturday Race - Local: 15:00 UTC+4)
        result.Add(new RaceEvent { EventName = "Azerbaijan Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 9, 26, 11, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Azerbaijan", Name = "Baku City Circuit" } });

        // Round 16: Bahrain Grand Prix (Relocated to Malaysia - Local: 23:00 UTC+8)
        result.Add(new RaceEvent { EventName = "Bahrain Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 10, 4, 15, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Malaysia", Name = "Sepang International Circuit" } });

        // Round 17: Singapore Grand Prix (Night Race - Local: 20:00 UTC+8)
        result.Add(new RaceEvent { EventName = "Singapore Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 10, 11, 12, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Singapore", Name = "Marina Bay Street Circuit" } });

        // Round 18: United States Grand Prix (Local: 15:00 UTC-5)
        result.Add(new RaceEvent { EventName = "United States Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 10, 25, 20, 0, 0, TimeSpan.Zero), Track = new Track { Country = "United States", Name = "Circuit of the Americas" } });

        // Round 19: Mexican Grand Prix (Local: 14:00 UTC-6)
        result.Add(new RaceEvent { EventName = "Mexican Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 11, 1, 20, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Mexico", Name = "Autódromo Hermanos Rodríguez" } });

        // Round 20: Brazilian Grand Prix (Local: 14:00 UTC-3)
        result.Add(new RaceEvent { EventName = "Brazilian Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 11, 8, 17, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Brazil", Name = "Autódromo José Carlos Pace" } });

        // Round 21: Las Vegas Grand Prix (Saturday Night Race - Local: 20:00 UTC-8)
        result.Add(new RaceEvent { EventName = "Las Vegas Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 11, 22, 4, 0, 0, TimeSpan.Zero), Track = new Track { Country = "United States", Name = "Las Vegas Strip Circuit" } });

        // Round 22: Qatar Grand Prix (Local: 19:00 UTC+3)
        result.Add(new RaceEvent { EventName = "Qatar Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 11, 29, 16, 0, 0, TimeSpan.Zero), Track = new Track { Country = "Qatar", Name = "Lusail International Circuit" } });

        // Round 23: Abu Dhabi Grand Prix (Local: 17:00 UTC+4)
        result.Add(new RaceEvent { EventName = "Abu Dhabi Grand Prix", Series = Series.Formula1, StartTime = new DateTimeOffset(2026, 12, 6, 13, 0, 0, TimeSpan.Zero), Track = new Track { Country = "United Arab Emirates", Name = "Yas Marina Circuit" } });

        return Task.FromResult(Result<ICollection<RaceEvent>>.Success(result));
    }

    public Task<Result<RaceEvent>> AddEvent(RaceEvent raceEvent)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ICollection<RaceEvent>>> GetEventsForSeries(string series)
    {
        throw new NotImplementedException();
    }
}