using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayMessage();

        string userName = YourUserName();
        int userNumber = YourNumber();

        int squaredNumber = NumberSquared(userNumber);

        ShowResult(userName, squaredNumber);
    }

    static void DisplayMessage() 
    {
        Console.WriteLine("Welcome!");
    }

    static string YourUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int YourNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;

    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}