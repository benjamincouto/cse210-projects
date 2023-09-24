using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {    
        //define variable for the menu option
        string optionSelected = "";

        //Journal object
        Journal theJournal = new Journal();

            Console.WriteLine("Welcome to the Journal Program!");

            while (optionSelected != "6")
            {
                //Display the menu
                Console.Write("""
                Please select one of the following choices:
                1. Write
                2. Find some inspiration
                3. Display
                4. Load
                5. Save
                6. Quit
                What would you like to do?  
                """);
                string selection = Console.ReadLine();
                
                optionSelected = selection;

                if (optionSelected == "1")
                {
                    //Generate a prompt calling the class PromptGenerator
                    PromptGenerator prompt = new PromptGenerator();
                    string newPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine(newPrompt);
                    Console.Write("> ");
                    
                    //The user will input his entry
                    string entry = Console.ReadLine();

                    //get today's date
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    //call the class Entry to store information
                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = newPrompt;
                    newEntry._entryText = entry;

                    //add entry to the _entries list with AddEntry method from Journal class                
                    theJournal.AddEntry(newEntry);

                    //blank line
                    Console.WriteLine("");

                }

                else if (optionSelected == "2")
                {
                    Console.WriteLine("Quote of the day: ");

                    QuoteGenerator randomQuote = new QuoteGenerator();
                    string quote = randomQuote.GetRandomQuote();
                    Console.WriteLine(quote);
                    
                    //blank line
                    Console.WriteLine("");

                }

                else if (optionSelected == "3")
                {
                    //display all entries with DisplayAll method from Journal class
                    theJournal.DisplayAll();

                    //blank line
                    Console.WriteLine("");
                }

                else if (optionSelected == "4")
                {
                    Console.WriteLine("What is the name of the file? ");
                    Console.Write("> ");
                    string fileName = Console.ReadLine();

                    Console.Write("Loading file...");

                    //load file according to fileName
                    theJournal.LoadFromFile(fileName);

                    Console.Write("File has been loaded.");

                    //blank line
                    Console.WriteLine("");
                    
                }

                else if (optionSelected == "5")
                {
                    Console.WriteLine("How would you like to name the file? ");
                    Console.Write("> ");
                    string fileName = Console.ReadLine();

                    //call the SaveToFile methon from Journal and add the fileName as a parameter
                    theJournal.SaveToFile(fileName);

                    //blank line
                    Console.WriteLine("");

                }


                else if (optionSelected == "6")
                {
                    Console.WriteLine("See you tomorrow! :)");
                    
                    //blank line
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Please select a valid option.");

                    //blank line
                    Console.WriteLine("");
                }

        }


    }
}