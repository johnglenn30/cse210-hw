using System;
using System.Collections.Generic;
using System.IO;

class SaveManager
{
    public static void SaveJournal(List<JournalEntry> journalEntries, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine(entry.DisplayEntry());
                    writer.WriteLine(); // Add a blank line between entries
                }

                Console.WriteLine($"Journal entries saved to {fileName}.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal entries: {ex.Message}");
        }
    }

    public static List<JournalEntry> LoadJournal(string fileName)
    {
        List<JournalEntry> loadedJournal = new List<JournalEntry>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string createDateStr = reader.ReadLine();
                    string prompt = reader.ReadLine();
                    string entryText = reader.ReadLine();

                    if (DateTime.TryParse(createDateStr, out DateTime createDate))
                    {
                        JournalEntry loadedEntry = new JournalEntry
                        {
                            _createDate = createDate,
                            _prompt = prompt,
                            _entryText = entryText
                        };

                        loadedJournal.Add(loadedEntry);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal entries: {ex.Message}");
        }

        return loadedJournal;
    }
}
