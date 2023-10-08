using System.Security.Principal;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity ()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 30;

        //add prompts to the _prompts list
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run ()
    {
        //display the message that will also set the duration according to the user's input
        DisplayStartingMessage ();
        

        //intro
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();



        //prompt user to get list
        List<string> responses = GetListFromUser();
        
        //count the responses and print it
        _count = responses.Count();
        Console.WriteLine($"You listed {_count} items!");
          
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

    public List<string> GetListFromUser ()
    {
        List<string> responsesList = new List<string>();
        
        //find current time to consider duration selected by the user
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            responsesList.Add(entry);       
        }   

        return responsesList;
    }

}