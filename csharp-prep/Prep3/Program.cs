using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 1000);
        int userNumber = -1;

        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userNumber = int.Parse(userGuess);

            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (!(userNumber == magicNumber));
    }
}