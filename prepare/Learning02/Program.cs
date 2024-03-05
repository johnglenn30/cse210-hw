using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._companyNow = "(Microsoft)";
        job1._startYear = 2011;
        job1._endYear = 2014;
        job1.DisplayTitle();

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._companyNow = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2023;
        job2.DisplayTitle();

        Resume newResume = new Resume();
        newResume._name = "John";

        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.DisplayResume();


        
        
    }
}