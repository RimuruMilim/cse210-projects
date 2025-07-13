public abstract class HomesteadItem
{
    public string Name { get; private set; }
    public string Zone { get; private set; }

    public HomesteadItem(string name, string zone)
    {
        Name = name;
        Zone = zone;
    }

    public abstract string GetStatus();
}
