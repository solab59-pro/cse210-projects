class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points.");
            return;
        }

        Goal goal = null;
        if (type == "1")
        {
            goal = new SimpleGoal(name, desc, points);
        }
        else if (type == "2")
        {
            goal = new EternalGoal(name, desc, points);
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            if (!int.TryParse(Console.ReadLine(), out int target)) { Console.WriteLine("Invalid target."); return; }
            Console.Write("Bonus points: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus)) { Console.WriteLine("Invalid bonus."); return; }
            goal = new ChecklistGoal(name, desc, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Unknown goal type.");
            return;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created!");
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created.");
            return;
        }

        Console.WriteLine("Select goal to record:");
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");

        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        int earned = goals[choice - 1].RecordEvent();
        totalScore += earned;
        Console.WriteLine($"You earned {earned} points! Total score: {totalScore}");
    }

    static void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created.");
            return;
        }

        Console.WriteLine("Your goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }
}


