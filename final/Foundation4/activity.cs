public abstract class Activity
{
    private DateTime _date;
    protected double _duration;

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public virtual double GetPace()
    {
        return _duration / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance {GetDistance():N1} km, Speed {GetSpeed():N1} kph, Pace: {GetPace():N1} min per km";
    }
}