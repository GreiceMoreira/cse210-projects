using System;

class Program
{
    static void Main(string[] args)
    {

        Running running = new("30.04.2024" , 30 , 20);
        Cycling cycling = new("29.04.2024" , 10 , 20);
        Swimming swimming = new("28.04.2024" , 10 , 10);
        
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}