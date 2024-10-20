public class RefletingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
       " --- Think of a time when you stood up for someone else. --- " ,
        " --- Think of a time when you did something really difficult. --- " ,
        " --- Think of a time when you helped someone in need --- " ,
        " --- Think of a time when you did something truly selfless. --- " ,
    };
    private List<string> _questions = new List<string>
    {
        " > Why was this experience meaningful to you?",
        " > Have you ever done anything like this before? ",
        " > How did you get started? ",
        " > How did you feel when it was complete?  ",
        " > What made this time different than other times when you were not as successful?",
        " > What is your favorite thing about this experience? ",
        " > What could you learn from this experience that applies to other situations?",
        " > What did you learn about yourself through this experience? ",
        " > How can you keep this experience in mind in the future?  "
    };
    
    public RefletingActivity(string name, string description)
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
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the pollowing questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        do {
            DisplayQuestions();
            time -= 7000;
        }while (time > 0);
        Console.WriteLine(" ");
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(" ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine(" ");
    }
    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(7);
        Console.WriteLine(" ");
    }


}