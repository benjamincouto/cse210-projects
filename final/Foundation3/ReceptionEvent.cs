public class ReceptionEvent : Event
{
    private string _rsvpEmail;


    public ReceptionEvent (string title, string description, DateTime dateAndTime, Address address, string rsvpEmail) : base (title, description, dateAndTime, address)
    {
        _rsvpEmail = rsvpEmail;

    }

    public override string GetEventType()
    {
        return "Reception Event";
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nRSVP: {_rsvpEmail}";
    }

}
