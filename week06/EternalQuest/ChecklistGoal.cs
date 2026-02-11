public class ChecklistGoal : Goal
{
    private int _totalRequired;
    private int _completedCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int totalRequired, int bonusPoints)
        : base(name, description, points)
    {
        _totalRequired = totalRequired;
        _completedCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override string GetDisplayString()
    {
        string status = _isCompleted ? "[X]" : $"[{_completedCount}/{_totalRequired}]";
        return $"{status} {_name} ({_description})";
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _completedCount++;
            base.RecordEvent();

            if (_completedCount >= _totalRequired)
            {
                _isCompleted = true;
                Console.WriteLine($"Bonus! You've earned {_bonusPoints} bonus points!");
            }
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_totalRequired},{_completedCount},{_bonusPoints},{_isCompleted}";
    }

    public override Goal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                int.Parse(parts[4]), int.Parse(parts[5]));
    }
}
