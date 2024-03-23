using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    public ListingActivity(List<string> prompts, string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        Console.WriteLine($"Running listing activity: {_name}");
        DisplayStartMessage();
        PromptUserForList();
        DisplayEndMessage();
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"Random prompt: {_prompts[index]}");
    }

    public void PromptUserForList()
    {
        Console.WriteLine("Please enter a list of items that you are thankful for(type 'q' to quit):");
        

        List<string> items = new List<string>();

        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "q")
            {
                break;
            }

            items.Add(input);
        }

        Console.WriteLine("List of items entered:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
