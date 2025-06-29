public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string ToCSV();
    public abstract void FromCSV(string data);

    public virtual int GetPoints() => _points;
    public bool IsComplete() => _isComplete;
    public virtual void Display()
    {
        Console.WriteLine(GetStatus());
    }
}