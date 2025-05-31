// public class Journal
// {
//     public List<Entry> _entries;

//     public void AddEntry(Entry newEntry)
//     {

//     }

//     public void DisplayAll()
//     {
//         foreach (Entry entry in _entries)
//     {
//       entry.Display();
//     }
//     }

//     public void SaveToFile(string file)
//     {

//     }

//     public void LoadToFile(string file)
//     {
        
//     }
// }

class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        DateTime date = DateTime.Parse(parts[2]);
                        Entries.Add(new Entry(prompt, response, date));
                    }
                }
            }
        }
        else
        {
            throw new FileNotFoundException("The specified journal file does not exist.");
        }
    }
}

