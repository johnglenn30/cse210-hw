using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var prompts = new List<string> { "What inspires you?", "Describe a happy memory." };
        var questions = new List<string> { "What did you learn today?", "What challenges did you face?" };

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    var breathingActivity = new BreathingActivity("Deep Breathing", "Relaxation technique", 5);
                    breathingActivity.Run();
                    break;
                case "2":
                    var listeningActivity = new ListingActivity(prompts, "Listing Activity", "Engage with others", 10);
                    listeningActivity.Run();
                    break;
                case "3":
                    var reflectingActivity = new ReflectingActivity(prompts, questions, "Self-Reflection", "Personal growth", 15);
                    reflectingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
            }
        }
    }
}
