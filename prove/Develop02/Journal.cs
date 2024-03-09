using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> _journal;

    public Journal()
    {
        _journal = new List<JournalEntry>();
    }

    public List<JournalEntry> GetJournal()
    {
        return _journal;
    }

    public void Save()
    {
        Console.Write("Enter a file name to save the journal entries: ");
        string fileName = Console.ReadLine();
        SaveManager.SaveJournal(_journal, fileName);
    }

    public void Load()
    {
        Console.Write("Enter a file name to load the journal entries: ");
        string fileName = Console.ReadLine();
        _journal = SaveManager.LoadJournal(fileName);
        Console.WriteLine($"Journal entries loaded from {fileName}.");
    }

    public void AddEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        _journal.Add(newEntry);
        Console.WriteLine("New entry added to the journal.");
    }

    public void Display()
    {
        Console.WriteLine("Journal Entries:");
        if (_journal.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (var entry in _journal)
            {
                Console.WriteLine(entry.DisplayEntry());
            }
        }
    }
}
