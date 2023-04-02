using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Activity> activities = new List<Activity>();

        
        DateTime runningDate = new DateTime(2023, 4, 1);
        int runningLength = 60;
        double runningDistance = 5;
        Activity running = new Running(runningDate, runningLength, runningDistance);
        activities.Add(running);

        
        DateTime bikeDate = new DateTime(2023, 4, 1);
        int bikeLength = 60;
        double bikeSpeed = 20;
        Activity bike = new StationaryBicycle(bikeDate, bikeLength, bikeSpeed);
        activities.Add(bike);

        
        DateTime swimDate = new DateTime(2023, 4, 1);
        int swimLength = 60;
        int swimLaps = 35;
        Activity swimming = new Swimming(swimDate, swimLength, swimLaps);
        activities.Add(swimming);

        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}