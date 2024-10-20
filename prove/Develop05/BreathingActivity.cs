using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int duration)
    {
        Duration = duration;
    }
    public void Run()
    {
        int time = Duration*1000;
        do{
            Console.WriteLine(" ");
            Console.Write("Breathe in ...");
            ShowCountDown(4);

            Console.Write("Now breathe out ...");
            ShowCountDown(5);

            Console.WriteLine(" ");

            time -= 10000;
        
        }while (time > 0);
    }


}