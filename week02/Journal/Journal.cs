using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("=== Your Journal Entries ===");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet. Add some!");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public int EntryCount()
    {
        return _entries.Count;
    }

    public void Save(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename, false))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine(entry.ToFileString());
            }
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Entry entry = Entry.FromFileString(line);
                    _entries.Add(entry);
                }
            }
        }
    }
}
