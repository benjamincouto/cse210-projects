public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent (string title, string description, DateTime dateAndTime, Address address, string speaker, int capacity) : base (title, description, dateAndTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetEventType()
    {
        return "Lecture Event";
    }

    
    public string FullDetails()
    {
        
        return $"{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }



}