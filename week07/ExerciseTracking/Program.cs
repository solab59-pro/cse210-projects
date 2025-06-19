using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),      // km
            new Cycling(new DateTime(2022, 11, 3), 45, 20.0),     // kph
            new Swimming(new DateTime(2022, 11, 3), 30, 20)       // laps
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}