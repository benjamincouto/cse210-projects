using System;

class Program
{
    static void Main(string[] args)
    {
        //define list to store instances
        List<Activity> activities = new List<Activity>();

        //running
        Running runningInstance1 = new Running(new DateTime(2023, 10, 20), 30, 6);
        activities.Add(runningInstance1);

        //cycling
        StationaryBike cyclingInstance1 = new StationaryBike(new DateTime(2023,10,22), 60, 25);
        activities.Add(cyclingInstance1);

        //swimming
        Swimming swimmingInstance1 = new Swimming(new DateTime(2023, 10, 24), 60, 20);
        activities.Add(swimmingInstance1);


        //loop to call GetSummary
        foreach (var activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("_______________________________________________________________________________");
        }


    }
}