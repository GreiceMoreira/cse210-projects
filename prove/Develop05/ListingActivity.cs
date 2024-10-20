using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    
    private List<string> _prompts = new List<string>
    {
        " --- Who are people that you appreciate? --- ",
        " --- What are personal strengths of yours? --- ",
        " --- Who are people that you have helped this week? --- ",
        " --- When have you felt the Holy Ghost this month? --- ",
        " --- Who are some of your personal heroes? --- "
    };

    public ListingActivity(string name, string description)
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
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        
        List<string> userList = GetListFromUser();

        _count = userList.Count();
        Console.WriteLine($"You listed {_count} items!");
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

     public List<string> GetListFromUser ()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        DateTime currentTime = DateTime.Now;

        List<string> userList = new List<string>();
        do
        {   
           Console.Write(">"); 
           userList.Add(Console.ReadLine());
            currentTime = DateTime.Now;
           
        }  while (currentTime < futureTime );

        return userList;
    }


}