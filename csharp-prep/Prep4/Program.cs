using System;
using System.Linq;
using System.Globalization;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string anwser = "";
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number: ");
            anwser = Console.ReadLine();
            int userNumber = int.Parse(anwser);
            if (userNumber != 0)
            {
                  numbers.Add(userNumber);
            }
          

        }while (anwser != "0");

        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        for(int i=0;i<numbers.Count;i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

