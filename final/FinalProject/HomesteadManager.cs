public class HomesteadManager
{
    private List<HomesteadItem> _items;
    private WeeklyPlanner _planner;
    private SkillProgress _skillProgress;

    public HomesteadManager()
    {
        _items = new List<HomesteadItem>();
        _planner = new WeeklyPlanner();
        _skillProgress = new SkillProgress();
    }

    public void AddItem(HomesteadItem item)
    {
        _items.Add(item);
    }

    public void AddTask(Task task)
    {
        _planner.AddTask(task);
    }

    public void UpdateSkill(string name, int progress)
    {
        _skillProgress.UpdateSkill(name, progress);
    }

    public WeeklyPlanner GetPlanner()
    {
        return _planner;
    }

    public void RunWeeklyTasks()
    {
        Console.WriteLine("Executing weekly tasks...");
        _planner.ExecuteAll();
    }

    public void ShowOverview()
    {
        Console.WriteLine("\nHomestead Items:");
        foreach (var item in _items)
        {
            Console.WriteLine(item.GetStatus());
        }

        Console.WriteLine("\nSkill Progress:");
        _skillProgress.DisplayProgress();
    }
}