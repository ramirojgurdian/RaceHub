using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api.Controllers;


[JsonConverter(typeof(SeriesJsonConverter))]
public class Series
{
    public string Name { get; }

    private Series(string name)
    {
        Name = name;
    }

    public static Series Formula1 => new("Formula 1");
    public static Series NASCAR => new("NASCAR");
    public static Series WEC => new("WEC");
    public static Series IMSA => new("IMSA");
    public static Series INDY => new("INDY");
    public static Series ELMS => new("ELMS");

    
}

public class SeriesJsonConverter : JsonConverter<Series>
{
    public override Series Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var name = reader.GetString();
        return name switch
        {
            "Formula 1" => Series.Formula1,
            "NASCAR" => Series.NASCAR,
            "WEC" => Series.WEC,
            "IMSA" => Series.IMSA,
            "INDY" => Series.INDY,
            "ELMS" => Series.ELMS,
            _ => throw new JsonException($"Unknown series: {name}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Series value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Name);
    }
}