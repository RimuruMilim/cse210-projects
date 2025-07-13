public class Plant : HomesteadItem
{
    public Plant(string name, string zone) : base(name, zone) { }

    public void Grow() { Console.WriteLine($"{Name} is growing..."); }

    public override string GetStatus()
    {
        return $"{Name} in {Zone} (Plant status placeholder)";
    }
}
