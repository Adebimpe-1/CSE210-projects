using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through slowly breathing in and out. Clear your mind and focus on your breathing.")
    {
    }

    public void Start()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseWithCountdown(4);
            Console.Write("Breathe out...");
            PauseWithCountdown(6);
        }

        EndActivity();
    }
}
