public class BadHabit : Goal
{
    public BadHabit(string name, string description, int points) : base(name, description, points)
    {
 
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"I'm sorry. You have lost {_points} points.");
        return -_points; 
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"BadHabit|{_shortName}|{_description}|{-_points}";
    }
}