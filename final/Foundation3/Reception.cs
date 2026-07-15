class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _email = email;
    }

    public override void FullDetails() //  all of the above, plus type of event and information specific to that event type (for lectures, this includes the speaker name and capacity; for receptions this includes an email for RSVP; for outdoor gatherings, this includes a statement of the weather)
    {
        StandardDetails();
        Console.WriteLine($"""
        Type: reception
        Capacity: must RSVP beforehand, contact {_email} to register
        """);
    }

    public override void ShortDetails() // type of event, title, and date
    {
        Console.WriteLine($"""
        Type: reception
        """); 
        base.ShortDetails();
    }
}