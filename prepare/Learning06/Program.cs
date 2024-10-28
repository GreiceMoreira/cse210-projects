using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Square: ");
        Square square = new("blue" , 4);
        Console.WriteLine("Color: " + square.Color);
        Console.WriteLine("Area: " + square.GetArea());
        Console.WriteLine(" ");

        Console.WriteLine("Rectangle: ");
        Rectangle rectangle = new("red" , 10 , 3);
        Console.WriteLine("Color: " + rectangle.Color);
        Console.WriteLine("Area: " + rectangle.GetArea());
        Console.WriteLine(" ");

        Console.WriteLine("Circle: ");
        Circle circle = new("pink" , 1);
        Console.WriteLine("Color: " + circle.Color);
        Console.WriteLine("Area: " + circle.GetArea());
        Console.WriteLine(" ");


    }
}