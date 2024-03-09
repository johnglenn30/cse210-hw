using System;
using System.Collections.Generic;

class PromptManager
{
    private static List<string> _prompts;

    static PromptManager()
    {
        _prompts = new List<string>
        {
            "What made you happy today?",
            "What challenges did you face today?",
            "Describe a memorable moment from today.",
            "If I had one thing I could do over today, what would it be?",
            "How did I see the hand of the Lord in my life today?"
        };
    }

    public static string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
