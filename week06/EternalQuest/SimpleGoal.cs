class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (completed)
        {
            Console.WriteLine("Goal already completed.");
            return 0;
        }
        completed = true;
        return Points;
    }

    public override string DisplayStatus()
    {
        return $"{(completed ? "[X]" : "[ ]")} {Name} ({Description}) - {Points} pts";
    }
}

