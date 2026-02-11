public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override string GetDisplayString()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isCompleted}";
    }

    public override Goal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
