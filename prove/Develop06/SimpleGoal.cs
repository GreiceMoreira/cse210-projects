
public class SimpleGoal : Goal
{
    public bool _isComplet = false;

    public SimpleGoal()
    {

    }
    public SimpleGoal(string shortName, string description, int points) : base( shortName , description , points )
    {   
      IsCompleted();
    }

    public override int RecordEvent()
    {
        if (IsCompleted()) {
            return 0;
        }
        _isComplet = true;
        return Points;
    }

    protected override bool IsCompleted()
    {
        return _isComplet;
    }
    public override string GetStringRepresentation()
    {
        return $"{ShortName}*{Description}*{Points}*{_isComplet}";
    }

}
