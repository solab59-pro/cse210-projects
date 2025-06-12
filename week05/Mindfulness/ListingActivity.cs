class ListingActivity : Activity
{
    private readonly List<string> prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    { }

    protected override void RunActivity()
    {
        Random rnd = new();
        int duration = GetDuration();

        string prompt = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to think...");
        ShowCountdown(5);

        List<string> items = new();

        Console.WriteLine("Start listing items. Press ENTER after each. Press ENTER without typing anything to finish early.");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(input))
                break;

            items.Add(input);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");
    }
}