// using System;
// using System.Formats.Asn1;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {

//         Console.WriteLine("Welcome to the Journal Project");
//         Console.WriteLine("Please select one of the following choices");
//         Console.WriteLine("1. Write");
//         Console.WriteLine("2. Display");
//         Console.WriteLine("3. Load");
//         Console.WriteLine("4. Save");
//         Console.WriteLine("5. Quit");

//         Console.WriteLine("What would you like to do? ");

//         string answer = Console.ReadLine();
//         int choice = int.Parse(answer); 

//         List<string> _prompts = new List<string>();
        


//         if (choice == 1)
//         {
           
//         }

//         else if (choice == 2)
//         {
            
//         }

//         else if (choice == 3)
//         {

//         }

//         else if (choice == 4)
//         {

//         }

//         else
//         {

//         }
//     }
        // string answer = Console.ReadLine();
        // int choice = int.Parse(answer);

        
        // if (choice == 1)
        // {
         
        // }
        // else if (choice == 2)
        // {

        // }
        // else if (choice == 3)
        // {

        // }
        // else if (choice == 4)
        // {

        // }
        // else if (choice == 5)
        // {

        // }
    // }

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        Console.Clear();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompt, response);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully! Press any key to continue...");
        Console.ReadKey();
    }

    static void DisplayJournal(Journal journal)
    {
        Console.Clear();
        if (journal.Entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            foreach (Entry entry in journal.Entries)
            {
                Console.WriteLine(entry.ToString());
                Console.WriteLine("------------");
            }
        }
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }

    static void SaveJournal(Journal journal)
    {
        Console.Clear();
        Console.Write("Enter the filename to save your journal: ");
        string filename = Console.ReadLine();

        try
        {
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully! Press any key to continue...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
        Console.ReadKey();
    }

    static void LoadJournal(Journal journal)
    {
        Console.Clear();
        Console.Write("Enter the filename to load your journal: ");
        string filename = Console.ReadLine();

        try
        {
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully! Press any key to continue...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
        Console.ReadKey();
    }
}