using System;

// Define a Journal class, which will be used to hold
// many Entry instances at once.
public class Journal
{
    // Member variables begin with an underscore.
    public List<Entry> _entries = new List<Entry>();

    // Constructor method.
    public Journal()
    {
    }

    // Make a brand-new entry!
    public void CreateEntry()
    {
        Entry newEntry = new Entry();
        newEntry.Create();
        _entries.Add(newEntry);
    }

    // Make a new entry with a user-defined prompt!
    public void CreateEntryWithPrompt()
    {
        Console.Write($"What prompt will you answer?: ");
        string temp_prompt = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry.Create(temp_prompt);
        _entries.Add(newEntry);
    }

    // Display relevant information.
    public void DisplayEntries()
    {
        int entry_count = 0;
        foreach (Entry e in _entries)
        {
            entry_count += 1;
            Console.WriteLine($"\nEntry #{entry_count}:");
            e.Display();
        }
    }

    // Save to a file.
    public void SaveToFile()
    {
        Console.WriteLine("What will you save this journal as? (Don't forget to add .txt!)");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Save every Entry, one at a time.
            int entry_count = 0;
            foreach (Entry e in _entries)
            {
                entry_count += 1;
                outputFile.WriteLine($"{e._date}|||{e._prompt}|||{e._response}");
            }
        }
    }

    // Load from a file.
    public void LoadFromFile()
    {
        Console.WriteLine("What file will you load? (Don't forget to add .txt!)");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        _entries = [];

        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");

            Entry newEntry = new Entry();
            newEntry._date = DateTime.Parse(parts[0]);
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            _entries.Add(newEntry);
        }
    }
}