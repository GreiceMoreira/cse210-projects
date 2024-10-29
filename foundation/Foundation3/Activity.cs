//For each activity, they want to track the the date and the length of the activity in minutes. 
public abstract class Activity
{
    public string Date {get; set;}
    public int Length {get; set;}

    public Activity(string date, int length)
    {
        Date = date;
        Length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        //Date TypeActivity (Length): Distance km , Speed: kph, Pace min per km
        return $"{Date} {this.GetType().Name} ({Length} min): Distance {GetDistance()} km, Speed {GetSpeed():0.00} kph, Pace {GetPace():0.00} min/km";
    }





}