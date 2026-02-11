using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Start()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        Console.WriteLine("Get ready to list items...");
        PauseWithCountdown(5);

        Console.Write("Enter as many items as you can in the time allotted...");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        string[] items = new string[100];
        int itemCount = 0;

        while (DateTime.Now < endTime && itemCount < 100)
        {
            Console.Write(" >");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items[itemCount] = item;
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items!");
        EndActivity();
    }
}
