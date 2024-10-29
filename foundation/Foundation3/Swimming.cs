public class Swimming : Activity
{
    public int Laps {get; set;}


    public Swimming(string date, int length, int laps) : base (date , length)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (double)Laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return (double)Length/GetDistance();
    }

    public override double GetSpeed()
    {
        return (double)60/GetPace();
    }


}