public class WaterTask : Task
{
    private Tree _tree;

    public WaterTask(string description, DateTime date, Tree tree) : base(description, date)
    {
        _tree = tree;
    }

    public override void Execute()
    {
        _tree.Water();
    }
}