using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Console.WriteLine("");
        Console.Write("What is your grade percentage? (No % needed): ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        char letter;

        if (number >= 90) {
            letter = 'A';
        } else if (number >= 80) {
           letter = 'B';
        } else if (number >= 70) {
            letter = 'C';
        } else if (number >= 60) {
            letter = 'D';
        } else {
            letter = 'F';
        }

        Console.WriteLine($"Grade: {letter}");

        if (number >= 70) {
            Console.WriteLine("Great Job! You Passed!");
        } else {
            Console.WriteLine("You did not pass. Keep Trying!");
        }

       


        
    }
}