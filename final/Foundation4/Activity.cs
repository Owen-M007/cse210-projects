abstract class Activity
{
    private string _date;
    private int _time; // in minutes

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetTime()
    {
        return _time;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {ToString()} ({_time} min) -";
    }
}