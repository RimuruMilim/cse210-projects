public class Tree : HomesteadItem
{
    private DateTime _lastWatered;
    private int _fruitYield;

    public Tree(string name, string zone) : base(name, zone)
    {
        _fruitYield = 0;
    }

    public void Water()
    {
        Console.WriteLine($"Watering {Name}...");
        _lastWatered = DateTime.Now;
    }

    public void Harvest(int fruit)
    {
        Console.WriteLine($"Harvesting {fruit} fruit from {Name}...");
        _fruitYield += fruit;
    }

    public override string GetStatus()
    {
        return $"{Name} in {Zone} - Last watered: {_lastWatered.ToShortDateString()}, Yield: {_fruitYield}";
    }
}