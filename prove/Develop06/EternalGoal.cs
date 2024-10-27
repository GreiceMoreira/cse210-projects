using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal()
    {

    }
    public EternalGoal(string shortName, string description, int points) : base( shortName , description , points )
    {

    }
    public override int RecordEvent()
    {
        return Points;
    }
    protected override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
             return $"{ShortName}*{Description}*{Points}";
    }
}

