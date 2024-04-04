public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points = 0;
    protected bool _isComplete = false;
    protected int _pointsForCompleted = 0;

    public Goal()
    {
        Console.WriteLine($"What is the name of your {GetFriendlyGoalTypeName()}? ");
        _shortName = Console.ReadLine();

        Console.WriteLine($"Describe your {GetFriendlyGoalTypeName()}? ");
        _description = Console.ReadLine();

        Console.WriteLine($"Enter the points to be awarded.{GetFriendlyGoalTypeName()}? ");
        _pointsForCompleted = Program.SafeParse();
    }
    public Goal(StreamReader read) 
    {
        _shortName = read.ReadLine();
        _description = read.ReadLine();
        _points = int.Parse(read.ReadLine());
        _pointsForCompleted = int.Parse(read.ReadLine());
        _isComplete = bool.Parse(read.ReadLine());
    }

    public string GetName()
    {
        return _shortName;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    protected string CompletedCheckbox()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public virtual string GetCompleteDisplayString()
    {
        return $"{CompletedCheckbox()} {_shortName}({_description})";
    }

    protected abstract string GetFriendlyGoalTypeName();

    public abstract void Complete();

    protected abstract string GetCompleteDescription();

    public virtual void WriteToStreamWriter(StreamWriter w)
    {
        w.WriteLine(_shortName);
        w.WriteLine(_description);
        w.WriteLine(_pointsForCompleted);
    }

}