class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails() //  all of the above, plus type of event and information specific to that event type (for lectures, this includes the speaker name and capacity; for receptions this includes an email for RSVP; for outdoor gatherings, this includes a statement of the weather)
    {
        StandardDetails();
        Console.WriteLine($"""
        Type: {ToString()}
        Speaker: {_speaker}
        Cpaacity: {_capacity} people
        """);
    }

    public override void ShortDetails() // type of event, title, and date
    {
        Console.WriteLine($"""
        Type: lecture
        """); 
        base.ShortDetails();
    }
}

