public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You earned {_points} points!");
    }

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";

    public override string ToCSV() => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";

    public override void FromCSV(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }
}