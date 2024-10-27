using System.Security.Cryptography;

public abstract class Goal
{
    public string ShortName { get; set; }
    public int Points { protected get; set; }
    public string Description { protected get; set; }
    
    public Goal()
    {

    }

    public Goal(string shortName, string description, int points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    protected abstract bool IsCompleted();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string check = "[ ]";
        if (IsCompleted())
        {
            check = "[X]";
        }
        return $" {check} {ShortName} ({Description})";
    }

}