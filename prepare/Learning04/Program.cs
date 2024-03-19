using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine("Homework");

        Assignment assignment1 = new Assignment();
        MathAssignment assignment = new MathAssignment();
        assignment1.SetStudentName("John");
        assignment1.SetTopic("Algebra AI");
        assignment.SetTextBookSection("Section 12:1");
        assignment.SetProblems("Problem 1-10");

         
        
        

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList()); 
       Console.WriteLine("\n");
       WritingAssignment a3 = new WritingAssignment();
       a3.SetStudentName("Jane");
       a3.SetTitle("Economic Reforms");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}