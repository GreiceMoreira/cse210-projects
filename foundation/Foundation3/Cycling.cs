public class Cycling : Activity
{
    public int Speed {get; set;}

    public Cycling(string date, int length, int speed) : base (date , length)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (double) Speed*Length / 60;
    }

    public override double GetPace()
    {
       return (double)60 / Speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }


}