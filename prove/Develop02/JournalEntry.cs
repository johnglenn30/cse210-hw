using System;

class JournalEntry
{
    public DateTime _createDate;
    public string _prompt;
    public string _entryText;

    public JournalEntry()
    {
        _createDate = DateTime.Now;
        _prompt = PromptManager.GetPrompt();

        Console.WriteLine($"Prompt: {_prompt}");

        Console.Write("Enter your journal entry: ");
        _entryText = Console.ReadLine();
    }

    public string DisplayEntry()
    {
        return $"{_createDate} - Prompt: {_prompt}\n{_entryText}\n";
    }
}
