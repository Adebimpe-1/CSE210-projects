using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public virtual string GetDisplayString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:_name,_description,_points,_isCompleted";
    }

    public abstract Goal CreateFromString(string data);

    public virtual  void RecordEvent()
    {
        if (!_isCompleted)
        {
            Console.WriteLine($"Congratulations! You've earned {_points} points!");
        }
    }

    public string GetName() => _name;
    public bool IsCompleted() => _isCompleted;
    public int GetPoints() => _points;
    public void SetCompleted(bool completed) => _isCompleted = completed;
}
