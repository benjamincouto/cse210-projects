public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity ()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times ...";
        _duration = 30;

        //add prompts to the _prompts list
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you faced a challenging decision and made the right choice.");
        _prompts.Add("Think of a time when you showed extraordinary patience in a difficult situation.");
        _prompts.Add("Think of a time when you forgave someone who wronged you.");
        _prompts.Add("Think of a time when you went out of your way to make someone's day better.");
        _prompts.Add("Think of a time when you stood up against an injustice and made a difference.");

        //add questions to the _questions list
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run ()
    {
        //display the message that will also set the duration according to the user's input
        DisplayStartingMessage ();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        //find current time to consider duration selected by the user
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {             
            DisplayQuestions();
            ShowSpinner(6);

            //if all questions were removed (avoiding dupes), add them back again with questionsBackup method
            if (_questions.Count == 0)
            {
                _questions.Clear();
                questionsBackup();
            }
        }    

        Console.WriteLine();

        DisplayEndingMessage();  
        
        //clear the console after 3 seconds
        Thread.Sleep(5000);
        Console.Clear();            



    }

    public string GetRandomPrompt ()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public string GetRandomQuestion ()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);

        string randomQuestion = _questions[randomIndex];
        
        //remove question at index to avoid duplicate questions
        _questions.RemoveAt(randomIndex);

        return randomQuestion;
    }

    public void DisplayPrompt ()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions ()
    {
        Console.WriteLine($"> {GetRandomQuestion()} ");     
    }

    private void questionsBackup ()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }
}