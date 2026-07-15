class OutdoorGathering : Event
{
    private string _weather;
    
    public OutdoorGathering(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weather = weather;
    }

    public override void FullDetails() //  all of the above, plus type of event and information specific to that event type (for lectures, this includes the speaker name and capacity; for receptions this includes an email for RSVP; for outdoor gatherings, this includes a statement of the weather)
    {
        StandardDetails();
        Console.WriteLine($"""
        Type: {ToString()}
        Weather: {_weather}
        """);
    }

    public override void ShortDetails() // type of event, title, and date
    {
        Console.WriteLine($"""
        Type: outdoor gathering
        """); 
        base.ShortDetails();
    }
}