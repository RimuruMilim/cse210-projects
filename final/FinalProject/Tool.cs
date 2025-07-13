public class Tool : HomesteadItem
{
    public Tool(string name, string zone) : base(name, zone) { }

    public void Repair() { Console.WriteLine($"Repairing {Name}..."); }

    public override string GetStatus()
    {
        return $"{Name} in {Zone} (Tool status placeholder)";
    }
}