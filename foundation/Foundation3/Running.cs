public class Running : Activity
{
    public int Distance {get; set;}

    public Running(string date, int length, int distance) : base (date , length)
    {
        Distance = distance;
    }


    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetPace()
    {
        return (double)Length/Distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }


}