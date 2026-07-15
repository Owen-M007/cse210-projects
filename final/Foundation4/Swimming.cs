class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
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
        return $"{base.GetSummary()} Laps: {_laps}, Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}