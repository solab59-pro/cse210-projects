

// public class PromptGenerator
// {
//     public List<string> _prompts;

//     public string GetRandomPrompt()
//     {
//         return "";
//     }
// }

class PromptGenerator
{
    public List<string> Prompts { get; set; }

    public PromptGenerator()
    {
        Prompts = new List<string>
        {
            "Did I help someonoe in need today?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I learn today that I didn't know before?",
            "What is something I am grateful for today?",
            "What did I learn from my scripture study today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
}