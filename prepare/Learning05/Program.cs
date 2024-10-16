using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment("Greice Moreira" , "Français");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Greice Moreira" , "Fractions", "7.3" , "8/19");
        Console.WriteLine(assignment2.GetHomeworkList());

        WrittingAssignemnt assignemnt3 = new WrittingAssignemnt("Greice Moreira", " English" , "My book");
        Console.WriteLine(assignemnt3.GetWritingInformation());

        
    }
}