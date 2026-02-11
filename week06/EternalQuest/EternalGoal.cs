public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    
    public override string GetDisplayString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points},false";
    }

    public override Goal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
