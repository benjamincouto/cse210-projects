using System;

public class Resume
{
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();

    
    public Resume()
    {
    }

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: ");
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
    }

}