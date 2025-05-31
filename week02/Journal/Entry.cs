// public class Entry
// {
//     public string _date;
//     public string _promptText;
//     public string _entryText;

//     public void Display()
//     {
//         //this is the file method used to display the job details
//         Console.WriteLine($"Date : {_date} - Prompt : {_promptText}");
//         Console.WriteLine($"Entry : {_entryText}");
//     }
// }

// // C# has a class that is used for working with dates and time of day called DateTime
// //you can get an object representing the current date and time with the DateTime.Now
// //Then, it has various methods that are helpful, such as .ToShortDateString()


// //the code
// //DateTime theCurrentTime = DateTime.Now;
// //string dateText = theCurrentTime.ToShortDateString();

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date.ToString("yyyy-MM-dd HH:mm:ss")}\nPrompt: {Prompt}\nResponse: {Response}";
    }

    public string ToFileFormat()
    {
        return $"{Prompt}|{Response}|{Date.ToString("yyyy-MM-dd HH:mm:ss")}";
    }
}
