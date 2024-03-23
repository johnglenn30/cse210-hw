// Activity.cs
using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting activity: {_name}");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done! You finished your {_name} Activity");
    }

    // public void DisplaySpinner()
    // {
    //     Console.WriteLine("Spinner is spinning...");
    // }
}
