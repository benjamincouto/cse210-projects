public class Swimming : Activity
{
    private int _laps;

    public Swimming (DateTime date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

}