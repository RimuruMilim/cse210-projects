public class SkillProgress
{
    private Dictionary<string, int> _skills;

    public SkillProgress()
    {
        _skills = new Dictionary<string, int>();
    }

    public void AddSkill(string name)
    {
        if (!_skills.ContainsKey(name))
            _skills[name] = 0;
    }

    public void UpdateSkill(string name, int progress)
    {
        if (_skills.ContainsKey(name))
        {
            _skills[name] = Math.Min(100, _skills[name] + progress);
        }
    }

    public void DisplayProgress()
    {
        foreach (var skill in _skills)
        {
            Console.WriteLine($"{skill.Key}: {skill.Value}% complete");
        }
    }
}
