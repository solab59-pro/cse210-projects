class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }
    private int currentCount = 0;
    public int CurrentCount => currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (completed)
        {
            Console.WriteLine("Checklist goal already completed.");
            return 0;
        }

        currentCount++;
        int earned = Points;
        if (currentCount >= TargetCount)
        {
            completed = true;
            earned += BonusPoints;
            Console.WriteLine($"Checklist goal complete! Bonus {BonusPoints} pts awarded.");
        }
        return earned;
    }

    public override string DisplayStatus()
    {
        return $"{(completed ? "[X]" : "[ ]")} {Name} ({Description}) - {Points} pts each, {BonusPoints} pts bonus at {TargetCount} times - Completed {currentCount}/{TargetCount}";
    }
}


