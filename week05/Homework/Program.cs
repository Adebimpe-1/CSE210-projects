using System;
using System.Threading;

class Program
{
    //Exceeds core requirements with session stats tracking
    // Tracks total activities completed and total time spent across sessions
    private static int _totalActivities = 0;
    private static int _totalTimeSpent = 0;

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program Menu:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select an option (1-4): ");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Start();
                _totalActivities++;
                _totalTimeSpent += breathing.GetDuration(); ;  
                break;
            case "2":
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Start();
                _totalActivities++;
                _totalTimeSpent += reflecting.GetDuration();
                break;
            case "3":
                ListingActivity listing = new ListingActivity();
                listing.Start();
                _totalActivities++;
                _totalTimeSpent += listing.GetDuration();
                break;
            case "4":
                Console.WriteLine($"Session complete! Total activities: {_totalActivities}, Total time: {_totalTimeSpent} seconds.");
                return;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }

        Console.WriteLine("Press Enter to continue to menu...");
        Console.ReadLine();
        Main(args);
    }
}
