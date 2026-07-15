class Running : Activity
{
    private double _distance;
    
    public Running(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetTime() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {_distance:F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}