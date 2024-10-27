using System.Drawing;
using Microsoft.VisualBasic;

public class ChecklistGoal : Goal
{
    public int AmountCompleted { protected get; set; }
    public int Target { protected get; set; }
    public int Bonus { protected get; set; }

    public ChecklistGoal()
    {

    }
    public ChecklistGoal(string shortName, string description, int points , int bonus , int accomplish, int target) : base( shortName , description , points )
    {
        Bonus = bonus;
        AmountCompleted = accomplish;
        Target = target;
    }
    public override int RecordEvent()
    {

        if (IsCompleted())
        {
            return 0;
        }
        AmountCompleted ++;

        if (IsCompleted())
        {
            return Points + Bonus;
        }
        return Points;
    }

    protected override bool IsCompleted()
    {     
        return Target == AmountCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"{ShortName}*{Description}*{Points}*{Bonus}*{AmountCompleted}*{Target}";
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Currently completed: {AmountCompleted}/{Target}";
    }

}







