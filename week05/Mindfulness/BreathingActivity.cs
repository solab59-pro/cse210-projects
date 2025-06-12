class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    { }

    protected override void RunActivity()
    {
        int duration = GetDuration();
        int elapsed = 0;
        int breatheDuration = 4;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(breatheDuration);
            elapsed += breatheDuration;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(breatheDuration);
            elapsed += breatheDuration;
        }
    }
}
