using System;

class Program
{
    static void Main(string[] args)
    {
        


        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();
        Console.WriteLine("Now is the Time Events");

        
        

        Address address= new Address();
        address.SetStreet("JRJ Function");
        address.SetCity("Koronadal");
        address.SetState("South Cotabato");
        address.SetCountry("Philippines");

        Lecture lecture= new Lecture("Federalism for the Philippines", "How federalism can improve the quality of governance and overall quality of life for Filipinos",DateTime.Now.Date, "Orion Dumdum",new TimeSpan(10, 0, 0),  address, 50);
        

        Console.WriteLine("Full Description");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description");
        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine();
    }
}