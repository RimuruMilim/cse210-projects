public class Structure : HomesteadItem
{
    private int _constructionPhase;
    private bool _isComplete;

    public Structure(string name, string zone) : base(name, zone)
    {
        _constructionPhase = 0;
        _isComplete = false;
    }

    public void CompletePhase()
    {
        _constructionPhase++;
        if (_constructionPhase >= 3) _isComplete = true;
        Console.WriteLine($"Progressing construction phase of {Name}...");
    }

    public override string GetStatus()
    {
        return _isComplete ? $"{Name} in {Zone} is complete." : $"{Name} in {Zone} is at phase {_constructionPhase}.";
    }
}