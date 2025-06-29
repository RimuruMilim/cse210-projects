public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
        }
    }

    public void DisplayScore() => Console.WriteLine($"Current Score: {_score}");

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
            writer.WriteLine(goal.ToCSV());
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal goal = parts[0] switch
            {
                "SimpleGoal" => new SimpleGoal("", "", 0),
                "EternalGoal" => new EternalGoal("", "", 0),
                "ChecklistGoal" => new ChecklistGoal("", "", 0, 0, 0),
                _ => throw new Exception("Unknown goal type")
            };
            goal.FromCSV(lines[i]);
            _goals.Add(goal);
        }
    }
}