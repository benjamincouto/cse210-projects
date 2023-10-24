using System;

class Program
{
    static void Main(string[] args)
    {

        // Creating an Address object
        Address eventAddress = new Address("123 Main St", "San Jose", "CA", "USA");

        LectureEvent lecture = new LectureEvent("Sample Lecture", "This is a sample lecture description.",
            new DateTime(2023, 11, 25, 14, 30, 00), eventAddress, "John Smith", 100);

        ReceptionEvent reception = new ReceptionEvent("Sample Reception", "This is a sample reception description.",
            new DateTime(2023, 11, 15, 18, 00, 00), eventAddress, "rsvp@example.com");

        OutdoorEvent outdoorGathering = new OutdoorEvent("Sample Outdoor Gathering", 
            "This is a sample outdoor gathering description.", new DateTime(2023, 12, 5, 12, 00, 00), 
            eventAddress, "Sunny with a high of 70°F");

        //Lecture
        Console.WriteLine("Event Details:");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine("\nFull Event Details:");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.ShortDescription());

        //line
        Console.WriteLine("_____________________________________");

        //Reception
        Console.WriteLine("\nEvent Details:");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine("\nFull Event Details:");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.ShortDescription());

        //line
        Console.WriteLine("_____________________________________");

        //Outdoor
        Console.WriteLine("\nEvent Details:");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine("\nFull Event Details:");
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGathering.ShortDescription());

    }
}