using System;
using System.Collections.Generic;
using System.Transactions;
// using Goals_gamify;

public class Program
{
    private static List<Goal> _goals = new List<Goal>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        
        while (true)
        {
            DisplayGoalsAndScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayGoalsAndScore();
                    break;
                 case "3":
                   SaveGoals();
                    break;
                 case "4":
                    LoadGoals();
                    break;
                 case "5":
                    // var recordEvent = new ChecklistGoals();
                    break;
                 case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-6.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine(
@"What type of Goal will you create?
1. Simple Goal
2. Eternal Goal
3. Checklist Goal");
        Console.Write("Enter the number of your choice: ");
        string input = Console.ReadLine();

        switch(input)
        {
            case "1":
                _goals.Add(new SimpleGoal());
                break;
            case "2":
                _goals.Add(new EternalGoal()); 
                break;
            case "3":
                _goals.Add(new ChecklistGoal());
                break;

        }
    }

    private static void DisplayGoalsAndScore()
    {
        Console.Clear();

        int score = 0;
        if (_goals.Count > 0)
        {
            Console.WriteLine("The goals are: ");
            foreach (Goal goal in _goals)
            {
                // Console.WriteLine(goal.CompleteDisplayString());
                // score += goal.GetPointsEarned;
            }
        }
        else
        {
            Console.WriteLine("There's nothing here.");
        }

        Console.WriteLine();
        Console.WriteLine($"You have {score} points");
        Console.WriteLine();

    }

    public static bool AreThereGoalsToRecord()
    {
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
                return true;
        }
        return false;
    }

    public static int DisplayNotCompletedGoals()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            Console.WriteLine($"{index++}.{goal.GetName()}");
        }
        return index -1;
    }

    public static Goal GetGoalToCompleteFromIndex(int indexToSelect)
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                if (index == indexToSelect)
                    return goal;
                index++;
            }
        }
        return null;

    }
    private static void RecordEvent()
    {
        if (!AreThereGoalsToRecord())
        {
            Console.WriteLine("There are no goals to record");
            return;
        }
        int choice = 0;
        int maxIndex = -1;
        while (choice <= 0 || choice > maxIndex)
        {
            Console.WriteLine("The goals available are: ");
            maxIndex = DisplayNotCompletedGoals();
            Console.WriteLine("Which goal did you complete? ");
            choice = SafeParse();
        }

        Goal theGoalToComplete = GetGoalToCompleteFromIndex(choice);
        System.Diagnostics.Debug.Assert(theGoalToComplete != null);
        theGoalToComplete.Complete();
    }

    private static void SaveGoals()
    {
        Console.Write("Save filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetType().FullName);
                goal.WriteToStreamWriter(writer);
            }
        }
    }

    private static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string typeLine = reader.ReadLine();
                switch (typeLine)
                {
                    case "GoalTracker.SimpleGoal":
                    _goals.Add(new SimpleGoal(reader));
                    break;
                    case "GoalTracker.ChecklistGoal":
                    _goals.Add(new ChecklistGoal(reader));
                    break;
                    case "GoalTracker.EternalGoal":
                    _goals.Add(new EternalGoal(reader));
                    break;
                    default:
                        Console.WriteLine("Invalid choice. Goal Creation cancelled.");
                        break;
                }
            }
        }
    }

    public static int SafeParse()
    {
        int result = 0;
        try
        {
            result = int.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            return 0;
        }
        catch (Exception)
        {
            throw;
        }

        return result;
    }
}