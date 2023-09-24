public class QuoteGenerator
{   


    public string GetRandomQuote()
    {
        string randomQuote = "";

        // Create a Random object to generate random numbers
        Random random = new Random();

        // Generate a random index within the range of the quotes file
        int randomIndex = random.Next(0, 13);

        string[] lines = System.IO.File.ReadAllLines("quotes.txt");

        randomQuote = lines[randomIndex];

        // foreach (string line in lines)
        // {
        // string[] parts = line.Split("|");

        // // Retrieve the random quote from the file
        // randomQuote = parts[randomIndex];

        // }

        return randomQuote;

    }    

}