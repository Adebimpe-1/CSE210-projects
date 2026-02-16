using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercise Tracking Program ===\n");

        // Req 6: Create instances of each type
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),      // 4.8km run
            new Cycling(new DateTime(2022, 11, 3), 30, 9.7),      // 9.7kph cycle
            new Swimming(new DateTime(2022, 11, 3), 30, 60)       // 60 laps swim
        };

        // Req 6: Polymorphism - ONE loop displays ALL activity types correctly!
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
