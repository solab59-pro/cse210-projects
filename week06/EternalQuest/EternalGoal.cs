class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points; // Never complete
    }

    public override string DisplayStatus()
    {
        return $"[∞] {Name} ({Description}) - {Points} pts each time (Eternal)";
    }
}

