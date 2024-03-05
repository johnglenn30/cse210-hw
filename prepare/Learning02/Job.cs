
public class Job
{
    public string _jobTitle;
    public string _companyNow;
    public int _startYear;
    public int _endYear;

    public void DisplayTitle()
    {
        Console.WriteLine($"{_jobTitle},{_companyNow},{_startYear}-{_endYear}");
    }

   
}