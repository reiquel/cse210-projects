public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}
