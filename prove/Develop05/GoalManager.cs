using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string userChoice = "";

            while (userChoice != "7")
            {
            //Display the menu
            Console.Write("""
            Menu options:
                1. Create New Goal
                2. List Goals
                3. Save Goals
                4. Load Goals
                5. Record Event
                6. Display Current Score
                7. Quit
            Select a choice from the menu: 
            """);

            string selection = Console.ReadLine();

            userChoice = selection;

            if (userChoice == "1")
            {
                CreateGoal();
            }

            else if (userChoice == "2")
            {
                ListGoalDetails();
            }

            else if (userChoice == "3")
            {
                SaveGoals();
                
            }

            else if (userChoice == "4")
            {
                LoadGoals();
            }

            else if (userChoice == "5")
            {
                RecordEvent();                
            }

            else if (userChoice == "6")
            {
                Console.WriteLine($"You have {_score} points.");                 
                                
            }

            else if (userChoice == "7")
            {

            }



            }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_goals[i].GetGoalName()}");
        }

    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1} {_goals[i].GetDetailsString()}");
        }

    }

    public void CreateGoal()
    {
        Console.Write("""
        The types of goals are:
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
            4. Bad Habit
        Which type of goal would you like to create?  
        """);

        string userChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);

        if (userChoice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (userChoice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);

        }

        else if (userChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string targetString = Console.ReadLine();
            int target = int.Parse(targetString);

            Console.Write("What is the bonus for accomplishing that many times? ");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);

        }

        else if (userChoice == "4")
        {
            BadHabit badGoal = new BadHabit(name, description, points);
            _goals.Add(badGoal);
            Console.WriteLine("Considering this is something you want to avoid, points will be deducted when an event is recorded.");
        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice) - 1;
        int pointsToAdd = _goals[choice].RecordEvent();
        _score += pointsToAdd;
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");     

    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal element in _goals)
            {
                outputFile.WriteLine(element.GetStringRepresentation());
            }
        }

    }

public void LoadGoals()
{
    Console.WriteLine("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    // Ensure there is at least one line in the file
    if (lines.Length > 0)
    {
        // Extract scoreString from the first line
        if (int.TryParse(lines[0], out int scoreString))
        {
            _score = scoreString;

            // Iterate through lines starting from index 1
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');

                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsStr = parts[3];
                    int points = int.Parse(pointsStr);
                    string complete = parts[4];


                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetIsComplete(complete);
                    _goals.Add(goal);

                }
                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsStr = parts[3];
                    int points = int.Parse(pointsStr);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);

                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsStr = parts[3];
                    int points = int.Parse(pointsStr);
                    string amountStr = parts[4];
                    int amount = int.Parse(amountStr);
                    string targetStr = parts[5];
                    int target = int.Parse(targetStr);
                    string bonusStr = parts[6];
                    int bonus = int.Parse(bonusStr);


                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    goal.SetAmount(amount);
                    _goals.Add(goal);

                }
            }
        }

        Console.WriteLine($"You have {_score} points.");
    }
    else
    {
        Console.WriteLine("The file is empty.");
    }
}


}

