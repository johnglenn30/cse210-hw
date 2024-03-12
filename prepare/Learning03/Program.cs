using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        // call constructors
        Fraction fraction1 = new Fraction();
        fraction1.Display();
        Console.WriteLine(fraction1.GetDecimal());

        Fraction fraction2 = new Fraction(5);
        fraction2.Display();
        Console.WriteLine(fraction2.GetDecimal());

        Fraction fraction3 = new Fraction(3, 4);
        fraction3.Display();
        Console.WriteLine(fraction3.GetDecimal());

        Fraction fraction4 = new Fraction(1,3);
        fraction4.Display();
        Console.WriteLine(fraction4.GetDecimal());
        
        
       

        


    }
}