using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber = 0;
        do 
        {
            Console.Write("What is your guess? ");
            string AGuessNumber = Console.ReadLine();
            guessNumber = int.Parse(AGuessNumber);
       
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
   
        }while(guessNumber != magicNumber);

        Console.WriteLine("Congratulations!");



    }
}