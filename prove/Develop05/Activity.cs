public class Activity
{
    protected string Name {get; set; }
    protected string Description {get; set; }
    protected int Duration {get; set; }

    public Activity()
    {
        Name = "name";
        Description = "description";
        Duration = 0;
    }

    public Activity(string name, string description , int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {Name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine(Description);
        Console.WriteLine(" ");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
       
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name}");
        ShowSpinner(3);
        Console.WriteLine(" ");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> character = new List<string>
            {"/" , "-" , "\\" , "|"}; 
        
        
        while (seconds>0)
        {
            foreach (string c in character)
            {
                Console.Write(c);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            seconds -= 2;
        }
    }

    public void ShowCountDown(int seconds)
    {
        do 
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds -= 1;

        }while (seconds > 0);
        Console.WriteLine(" ");
    }



}