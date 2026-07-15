class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    
}