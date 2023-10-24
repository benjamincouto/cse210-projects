using System;
public class Event

{
    protected string _title;
    protected string _description;
    protected DateTime _dateAndTime;
    protected Address _address;

    public Event (string title, string description, DateTime dateAndTime, Address address)
    {
        _title = title;
        _description = description;
        _dateAndTime = dateAndTime;
        _address = address;

    }

    public virtual string GetEventType()
    {
        return "Event";
    }

    // Standard details - Lists the title, description, date, time, and address.
    public string StandardDetails()
    {
        // Format the date as MM/dd/YYYY
        string formattedDate = _dateAndTime.ToString("MM/dd/yyyy"); 
        // Format the time hh:mm tt
        string formattedTime = _dateAndTime.ToString("h:mm tt");

        return $"{_title}\n{_description}\nIt will be on {formattedDate} at {formattedTime}\n{_address.FullAddress()}";
    }

    public string ShortDescription()
    {
        // Format the date as MM/dd/YYYY
        string formattedDate = _dateAndTime.ToString("MM/dd/yyyy"); 
        return $"{GetEventType()}\n{_title}\n{formattedDate}";
    }
}