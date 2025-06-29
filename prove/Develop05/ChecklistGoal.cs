public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You earned {_points} points!");
        if (_currentCount >= _targetCount && !_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Bonus! You earned {_bonusPoints} bonus points!");
        }
    }

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";

    public override string ToCSV() => $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonusPoints}|{_currentCount}|{_targetCount}|{_isComplete}";

    public override void FromCSV(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _bonusPoints = int.Parse(parts[4]);
        _currentCount = int.Parse(parts[5]);
        _targetCount = int.Parse(parts[6]);
        _isComplete = bool.Parse(parts[7]);
    }
}
