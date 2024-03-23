// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        Console.WriteLine($"\n \nRunning breathing activity: {_name}");

        //  Get ready countdown
       Console.WriteLine("\n \nWelcome to the Breathing Exercise we will use the 4-7-8 method. \n\nThe 4-7-8 technique forces the mind and body to focus on regulating the breath, rather than replaying your worries when you lie down at night. Proponents claim it can soothe a racing heart or calm frazzled nerves. Dr. Weil has even described it as a “natural tranquilizer for the nervous system\n\nCAUTION: This breathing technique shouldn’t be practiced in a setting where you’re not prepared to fully relax. While it doesn’t necessarily have to be used for falling asleep, it can still put the practitioner into a state of deep relaxation. Make sure you don’t need to be fully alert immediately after practicing your breathing cycles.\n\nThis technique is relatively safe, and can actually benefit your health. However, if you're a beginner, you should only practice 4 cycles and work up until 8 cycles only at a time until you're more comfortable with the practice. Avoid practicing breathwork if you are pregnant or have a severe medical condition.\n\n Have a Relaxing time!\n\n");

        Console.Write("Enter the number of breathing cycles: ");
        if (int.TryParse(Console.ReadLine(), out int cycles) && cycles > 0)
        
        {
            
            Console.WriteLine("You have 8 seconds to relax and get ready...");
            CountdownTimer(8); // 10 seconds countdown

            for (int i = 1; i <= cycles; i++)
            {
                Console.Write($"Cycle {i}:");
                Console.WriteLine("Breathe in deeply for 4 seconds...");
                CountdownTimer(4); // User-specified duration for breathing in

                Console.WriteLine("Hold your breath for 7 seconds...");
                CountdownTimer(7); // User-specified duration for breathing out

                Console.WriteLine("Breath out for 8 seconds...");
                CountdownTimer(8); // User-specified duration for breathing out
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
        Console.Write("Time Left: ");
        for (int i = seconds; i >= 0; i--)
        {
            
            Console.Write(i);
            Console.Write("\b");

            
            System.Threading.Thread.Sleep(1000);
        }
    }
}
