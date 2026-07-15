class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * 60 / GetTime();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {GetDistance():F1} km, Speed {_speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}