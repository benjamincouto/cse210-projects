
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    

    public string GetRandomPrompt()
    {
        // Initialize the list of prompts if it's empty
        if (_prompts.Count == 0)
        {
            _prompts.Add("What am I grateful for today?");
            _prompts.Add("What was the most significant event of your day?");
            _prompts.Add("What valuable lesson did you learn today?");
            _prompts.Add("How did you feel throughout the day?");
            _prompts.Add("Did you feel loved or did you help someone feel loved?");
            _prompts.Add("What changes or adjustments would you make tomorrow based on your experiences today?");
        }

        // Create a Random object to generate random numbers
        Random random = new Random();

        // Generate a random index within the range of the prompts list
        int randomIndex = random.Next(0, _prompts.Count);

        // Retrieve the random prompt from the list
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;

    }
}