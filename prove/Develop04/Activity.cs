public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity ()
    {
                
    }

    public void DisplayStartingMessage ()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        Console.WriteLine("");

        //clear the console
        Console.Clear();

        //get ready and spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        
    }

    public void DisplayEndingMessage ()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Console.WriteLine("");
    }

    public void ShowSpinner (int seconds)
    {
        List<string> spinnerString = new List<string>();
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            
            if (i >= spinnerString.Count)
            {
                i = 0;
            }
        }
        
    }

    public void ShowCountDown (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }
}