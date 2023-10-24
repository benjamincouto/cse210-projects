using System.Reflection;

public class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent (string title, string description, DateTime dateAndTime, Address address, string weatherForecast) : base (title, description, dateAndTime, address)
    {
        _weatherForecast = weatherForecast;

    }

    public override string GetEventType()
    {
        return "Outdoor Event";
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }

}