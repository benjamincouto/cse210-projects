
using System.Diagnostics;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"""
        Date: {_date} - Prompt: {_promptText}
        {_entryText}
        
        """);

    }
}