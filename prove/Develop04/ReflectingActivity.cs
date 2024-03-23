// ReflectingActivity.cs
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.WriteLine($"Running reflecting activity: {_name}");
        DisplayStartMessage();

       

        Console.Write("\n\nEnter the number of cycles you want to ponder about the random question each cycle is 30 seconds long: ");
        if (int.TryParse(Console.ReadLine(), out int cycles) && cycles > 0)
        {
            DisplayRandomPrompt();
            for (int i = 1; i <= cycles; i++)
            {
                Console.WriteLine($"Cycle {i}:");

                
                CountdownTimer(30); 

            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        DisplayEndMessage();
    }

    private void CountdownTimer(int seconds)
    {
        Console.Write("Time left: ");
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(".");
            // Console.Write("\b  \b");
            System.Threading.Thread.Sleep(1000);
        }
    }

    private void DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"Random prompt: {_prompts[index]}");
    }

    private void DisplayRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine($"Random question: {_questions[index]}");
    }
}
