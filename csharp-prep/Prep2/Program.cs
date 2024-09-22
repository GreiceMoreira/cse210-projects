using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their grade percentage, 
        Console.Write("What is you grade percentage? ");
        string userAnwserGrade = Console.ReadLine();
        int userGradePercentage = int.Parse(userAnwserGrade);

        string letter = "X";

        if (userGradePercentage >= 90 )
        {
            letter = "A";
        }

        else if (userGradePercentage >= 80)
        {
            letter = "B";
        }

        else if (userGradePercentage >= 70)
        {
            letter = "C";
        }

        else if (userGradePercentage >= 60)
        {
            letter = "D";
        }

        else if(userGradePercentage < 60 && userGradePercentage > 0)
        {
            letter = "F";
        }

        else
        {
            Console.Write("Unvalible value");
        }
        
        Console.WriteLine($"Your grade percentage is {userGradePercentage}. You have {letter}.");

        if (userGradePercentage >= 70)
        {
            Console.WriteLine("Congratulation!");
        }

        else
        {
            Console.WriteLine("Continue to make efforts in the next semester");
        }


/*

Stretch Challenge
Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.

Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might review the standard math operators and find the one that does division and gives you the remainder.

At this point, don't worry about the exceptional cases of A+, F+, or F-.

Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.
         */
    }
}