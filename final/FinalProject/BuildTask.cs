public class BuildTask : Task
{
    private Structure _structure;

    public BuildTask(string description, DateTime date, Structure structure) : base(description, date)
    {
        _structure = structure;
    }

    public override void Execute()
    {
        _structure.CompletePhase();
    }
}
