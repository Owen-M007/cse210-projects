class Activity
{
    private string _date;
    private int _time; // minutes
    private double _distance; // kilometres
    private double _speed; // kilometres per hour
    private double _pace; // minutes per kilometre

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }
    public virtual void SetDistance(double distance)
    {
        _distance = distance;
    }

    public virtual void SetSpeed()
    {
        _speed = _distance / _time * 60;
    }

    public virtual void SetPace()
    {
        _pace = _time / _distance;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return _speed;
    }

    public virtual double GetPace()
    {
        return _pace;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {ToString()} ({_time} min) - Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km");
    }
}