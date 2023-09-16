using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int userInputNumber = int.Parse(userInput); 

        string letter = "";

        if (userInputNumber >= 90)
        {
            letter = "A";
        }
        else if (userInputNumber >= 80)
        {
            letter = "B";
        }
        else if (userInputNumber >= 70)
        {
            letter = "C";
        }
        else if (userInputNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (userInputNumber % 10 >= 7)
        {
            if (letter == "A")
            {
                Console.WriteLine($"Your grade is {letter}");
            }
            else
            {
                Console.WriteLine($"Your grade is {letter}+");
            }       
        }
        else if (userInputNumber % 10 < 3)
        {
            if (letter == "F")
            {
                Console.WriteLine($"Your grade is {letter}");
            }
            else
            {
                Console.WriteLine($"Your grade is {letter}-");
            } 
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        
        
        if (userInputNumber >= 70)
        {
            Console.WriteLine("Congratulations, you have passed!");
        } 
        else
        {
            Console.WriteLine("I'm sorry, you have not passed. We encourage you to try again.");
        }
    }
}