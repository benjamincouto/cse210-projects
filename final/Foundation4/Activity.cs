public abstract class Activity
{
    protected DateTime _date;
    protected double _minutes;

    public Activity (DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
    
    public string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        return $"{formattedDate} ({_minutes} min) | Distance: {GetDistance()} km | Speed: {GetSpeed()} km/h | Pace: {GetPace()} min per km";
    }
}