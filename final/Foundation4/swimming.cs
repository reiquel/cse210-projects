public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }
}