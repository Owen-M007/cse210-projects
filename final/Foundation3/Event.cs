class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address();
    }

    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _address.SetStreet(street);
        _address.SetCity(city);
        _address.SetStateOrProvince(stateOrProvince);
        _address.SetCountry(country);
    }

    public void StandardDetails() // title, description, date, time, and address
    {
        Console.WriteLine($"""
        Title: {_title}
        Description: {_description}
        Date: {_date}
        time: {_time}
        Address: {_address.FullAddress()}
        """);
    }

    public virtual void FullDetails() //  all of the above, plus type of event and information specific to that event type (for lectures, this includes the speaker name and capacity; for receptions this includes an email for RSVP; for outdoor gatherings, this includes a statement of the weather)
    {
    }

    public virtual void ShortDetails() // type of event, title, and date
    {
        Console.WriteLine($"""
        Title: {_title}
        Date: {_date}
        """);
    }
}