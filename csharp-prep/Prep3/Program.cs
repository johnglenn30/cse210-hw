using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomNum = new Random();
        int number = randomNum.Next(1, 50);

        int guess = -1;

        while (guess != number) 
        {
            Console.Write("Guess the number between 1-50: ");
            guess = int.Parse(Console.ReadLine());

            if ( number > guess) 
            {
                Console.WriteLine("Higher");
            } 
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            } 
            else 
            {
                Console.WriteLine("You guessed it");
            }
            
         
        }
    }
}