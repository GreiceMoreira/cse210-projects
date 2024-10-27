using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Web;

public class GoalManager
{
    public List<Goal> Goals { get; set; }
    public int Score { get; set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        Score = 0;
    }

    public void Start()
    {
        //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        int anwser = 0;
        do
        {

            Console.WriteLine(" ");
            DisplyPlayerInfo();
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            anwser = int.Parse(Console.ReadLine());
            if (anwser == 1)
            {
                CreateGoal();
            }
            else if (anwser == 2)
            {
                ListGoalsDetails();
            }
            else if (anwser == 3)
            {
                Console.Write($" What is the filename for the goal file? ");
                string file = Console.ReadLine();
                SaveGoals(file);
            }
            else if (anwser == 4)
            {
                Console.Write($" What is the filename for the goal file?");
                string file = Console.ReadLine();
                LoadGoals(file);
            }
            else if (anwser == 5)
            {
                RecordEvent();
            }

        } while (anwser != 6);


    }

    public void DisplyPlayerInfo()
    {
        //Displays the players current score.

        Console.WriteLine($"You have {Score} points.");
    }

    public void CreateGoal()

    {
        //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simples Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            SimpleGoal newGoal = new SimpleGoal();
            AskQuestion(newGoal);
            Goals.Add(newGoal);
        }
        else if (goalType == 2)
        {
            EternalGoal newGoal = new EternalGoal();
            AskQuestion(newGoal);
            Goals.Add(newGoal);
        }
        else
        {
            ChecklistGoal newGoal = new ChecklistGoal();
            AskQuestion(newGoal);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            newGoal.Target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplish it that many times? ");
            newGoal.Bonus = int.Parse(Console.ReadLine());
            Goals.Add(newGoal);
        }
    }

    public void ListGoalsNames()

    {
        Console.WriteLine(" The goals are: ");
        if (Goals.Count != 0)
        {
            int index = 1;
            foreach (Goal goal in Goals)
            {
                Console.WriteLine($"{index} ."+ goal.ShortName);
                index ++;
            }
        }
    }

    public void ListGoalsDetails()

    {
        Console.WriteLine(" The goals are: ");
        if (Goals.Count != 0)
        {
            int index = 1;
            foreach (Goal goal in Goals)
            {
                Console.WriteLine($"{index} ." + goal.GetDetailsString());
                index++;
            }
        }
    }

    public void SaveGoals(string file)
    {
        // Saves the list of goals to a file.
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(Score);
            foreach (Goal goal in Goals)
            {
                outputFile.WriteLine(goal + ":" + goal.GetStringRepresentation());

            }
        }
        Console.WriteLine($"We save your goals in {file} file!");
    }

    public void LoadGoals(string file)

    {
        //Loads the list of goals from a file.
        string firstLine = File.ReadLines(file).FirstOrDefault();
        Score = int.Parse(firstLine);

        string[] lines = File.ReadAllLines(file).Skip(1).ToArray();
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");  
            string goalType = parts[0];
            string goalDetails = parts[1];

            string[] details = goalDetails.Split("*");

            string shortName = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);
            
            if (goalType == "SimpleGoal")
            {
                Goal goal = new SimpleGoal(shortName, description, points);
                Goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                Goal goal = new EternalGoal(shortName, description, points);
                Goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(details[3]);
                int accomplish = int.Parse(details[4]);
                int target = int.Parse(details[5]);

                Goal goal = new ChecklistGoal(shortName, description, points, bonus, accomplish ,target);
                Goals.Add(goal);
            }
        }
        ListGoalsDetails();
    }

    public void RecordEvent()

    {        
        ListGoalsNames();
        Console.Write("Which goal did you accomplish? ");
        int anwser = int.Parse(Console.ReadLine());

        Goal goal = Goals[anwser-1];
        int points = goal.RecordEvent();

        Console.WriteLine($"Congratulations! You have earned {points} points!");

        Score += points;
        Console.WriteLine($"You now have {Score}");

    }

    public Goal AskQuestion(Goal newGoal)
    {
        Console.Write("What is the name of your goal? ");
        newGoal.ShortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        newGoal.Description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        newGoal.Points = int.Parse(Console.ReadLine());

        return newGoal;
    }






}