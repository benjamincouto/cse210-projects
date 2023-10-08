public class BreathingActivity : Activity
{
    public BreathingActivity ()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 30;
    }

    public void Run ()
    {
        //display the message that will also set the duration according to the user's input
        DisplayStartingMessage ();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);     

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6); 
            Console.WriteLine();
            Console.WriteLine();           
        }

        //end message
        DisplayEndingMessage();

        //clear the console after 3 seconds
        Thread.Sleep(5000);
        Console.Clear();


    }
}