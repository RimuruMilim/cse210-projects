public abstract class Task
{
    public string Description { get; protected set; }
    public DateTime ScheduledDate { get; private set; }

    public Task(string description, DateTime date)
    {
        Description = description;
        ScheduledDate = date;
    }

    public abstract void Execute();
}
