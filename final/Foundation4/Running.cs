using System.Data.Common;

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        _distanceKm = distance;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (_distanceKm / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distanceKm;
    }

}