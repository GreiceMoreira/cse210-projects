using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Console.WriteLine("Give me a top number: ");
        int userTop = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Give me a bottom number: ");
        int userBottom= int.Parse(Console.ReadLine());

        Fraction f1 = new Fraction();
        Console.Write("F1: ");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(userTop);
        Console.Write("F2: ");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(userTop , userBottom);
        Console.Write("F3: ");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        

        
    }
}