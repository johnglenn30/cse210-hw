using System.IO;
public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
    }

    public SimpleGoal(StreamReader read) : base(read)
    {
    }

    public override void Complete()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            _points += _pointsForCompleted;
        }
    }

    protected override string GetCompleteDescription()
    {
        return "completion";
    }

    protected override string GetFriendlyGoalTypeName()
    {
       return "one-time goal";
    }
}