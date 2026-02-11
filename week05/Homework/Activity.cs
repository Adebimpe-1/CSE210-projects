using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration; 
    public int GetDuration()
    {
        return _duration;
    }


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        DisplayStartingMessage();
    }

    public void EndActivity()
    {
        DisplayEndingMessage();
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        PauseWithSpinner(3);
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine("Get ready...");
        PauseWithSpinner(2);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b ");
        }
        Console.WriteLine();
    }
}
