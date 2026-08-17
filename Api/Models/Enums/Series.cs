namespace Api.Controllers;

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
