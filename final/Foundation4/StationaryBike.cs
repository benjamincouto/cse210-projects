public class StationaryBike : Activity
{
    private double _speedKph;

    public StationaryBike (DateTime date, double minutes, double speed) : base(date, minutes)
    {
        _speedKph = speed;
    }

    public override double GetDistance()
    {
        return (_speedKph / 60) * _minutes;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }


}