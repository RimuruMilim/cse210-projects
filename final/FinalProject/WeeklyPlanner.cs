public class WeeklyPlanner
{
    private List<Task> _taskList;

    public WeeklyPlanner()
    {
        _taskList = new List<Task>();
    }

    public void AddTask(Task task)
    {
        _taskList.Add(task);
    }

    public void ExecuteAll()
    {
        foreach (var task in _taskList)
        {
            task.Execute();
        }
        _taskList.Clear();
    }

    public void ShowTasks()
    {
        for (int i = 0; i < _taskList.Count; i++)
        {
            var task = _taskList[i];
            Console.WriteLine($"[{i + 1}] {task.ScheduledDate.ToShortDateString()} - {task.Description}");
        }
    }

    public void ExecuteTask(int index)
    {
        if (index >= 0 && index < _taskList.Count)
        {
            _taskList[index].Execute();
            _taskList.RemoveAt(index);
        }
    }

    public bool HasTasks()
    {
        return _taskList.Count > 0;
    }
}