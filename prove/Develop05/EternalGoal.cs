using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal
{
    public EternalGoal() : base()
    { 
    }

    public EternalGoal(StreamReader read) : base(read)
    {
    }

    protected override string GetCompleteDescription()
    {
        return "each time this habit is repeated";
    }

    protected override string GetFriendlyGoalTypeName()
    {
        return "eternal habit";
    }

    public override void Complete()
    {
        _isComplete = false;
        _points += _pointsForCompleted;
    }
}