using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

            while (userChoice != "4")
            {
                Console.Clear();
                //Display the menu
                Console.Write("""
                Menu options:
                    1. Start breathing activity
                    2. Start reflecting activity
                    3. Start listing activity
                    4. Quit
                Select a choice from the menu: 
                """);

                string selection = Console.ReadLine();

                userChoice = selection;

                if (userChoice == "1")
                {
                    Console.Clear();
                    BreathingActivity bActivity = new BreathingActivity();
                    bActivity.Run();
                }

                else if (userChoice == "2")
                {
                    Console.Clear();
                    ReflectingActivity rActivity = new ReflectingActivity();
                    rActivity.Run();
                }

                else if (userChoice == "3")
                {
                    Console.Clear();
                    ListingActivity lActivity = new ListingActivity();
                    lActivity.Run();
                }

                else if (userChoice == "4")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    Thread.Sleep(3000);

                }

                
                
            }
            ;





    }
}