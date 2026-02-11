using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    // Exceeds core requirements with LEVEL SYSTEM gamification
    // Users level up every 1000 points (Level 1 Ninja → Level 2 Master → etc.)
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;
    private static int _level = 1;

    static void Main(string[] args)
    {
        Console.Clear();
        LoadGoals();

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    RecordEventPrompt();
                    break;
                case "3":
                    DisplayScore();
                    break;
                case "4":
                    SaveGoals();
                    Console.WriteLine("Goals saved. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Eternal Quest ===");
        Console.WriteLine($"Score: {_score} points (Level {_level} {_GetLevelTitle()})");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Show Score");
        Console.WriteLine("4. Save and Quit");
        Console.WriteLine("Select option: ");
    }

    static void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which goal? ");
        string type = Console.ReadLine();

        Console.Write("What is the goal name? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description? ");
        string description = Console.ReadLine();
        Console.Write("What are the points? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times? ");
                int times = int.Parse(Console.ReadLine());
                Console.Write("Bonus points? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, times, bonus));
                break;
        }
        Console.WriteLine("Goal created!");
        Pause();
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    static void RecordEventPrompt()
    {
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal goal = _goals[index - 1];
            goal.RecordEvent();
            _score += goal.GetPoints();
            UpdateLevel();
        }
        Pause();
    }

    static void DisplayScore()
    {
        Console.WriteLine($"\n=== Your Progress ===");
        Console.WriteLine($"Score: {_score} points");
        Console.WriteLine($"Level: {_level} - {_GetLevelTitle()}");
        Pause();
    }

    static string _GetLevelTitle()
    {
        return _level switch
        {
            1 => "Apprentice",
            2 => "Journeyman",
            3 => "Master",
            4 => "Grandmaster",
            5 => "Legend",
            _ => "Eternal Champion"
        };
    }

    static void UpdateLevel()
    {
        _level = _score / 1000 + 1;
    }

    static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        UpdateLevel();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];

            Goal goal = type switch
            {
                "SimpleGoal" => new SimpleGoal("", "", 0).CreateFromString(lines[i]),
                "EternalGoal" => new EternalGoal("", "", 0).CreateFromString(lines[i]),
                "ChecklistGoal" => new ChecklistGoal("", "", 0, 0, 0).CreateFromString(lines[i]),
                _ => null
            };

            if (goal != null) _goals.Add(goal);
        }
    }

    static void Pause()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
