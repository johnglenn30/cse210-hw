using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        {
            List<int> numbers = new List<int>();
        
           
            int userInt = -1;
            while (userInt != 0)
            {
                Console.Write("Enter a number (press 0 to quit): ");
                
                string userResponse = Console.ReadLine();
                userInt = int.Parse(userResponse);
                
               
                if (userInt != 0)
                    {
                        numbers.Add(userInt);
                    }
            }

          
            int sum = 0;
            foreach (int number in numbers)
            {
            sum += number;
        }

        Console.WriteLine($"The total is: {sum}");

       
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
    }
}