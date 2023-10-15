using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points.");
            return _points;
        }
        else
        {
            Console.WriteLine($"You have already completed this goal. You may create a new one.");
            return 0;
        }
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(string text)
    {
        if (text == "True")
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }


}