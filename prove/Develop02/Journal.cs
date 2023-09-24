public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
        // loop to add the entries to the file from the list
        foreach (Entry e in _entries)
        {
            outputFile.WriteLine($"{e._date}||{e._promptText}||{e._entryText}");
        }

        Console.WriteLine("Your entries are saved.");
            
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
        string[] parts = line.Split("|");

        Entry entryFromFile = new Entry();
        entryFromFile._date = parts[0];
        entryFromFile._promptText = parts[1];
        entryFromFile._entryText = parts[2];

        _entries.Add(entryFromFile);
        }

        
    }
}