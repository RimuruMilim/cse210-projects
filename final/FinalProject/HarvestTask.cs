public class HarvestTask : Task
{
    private Tree _tree;
    private int _fruitAmount;

    public HarvestTask(string description, DateTime date, Tree tree, int amount) : base(description, date)
    {
        _tree = tree;
        _fruitAmount = amount;
    }

    public override void Execute() { }
}
