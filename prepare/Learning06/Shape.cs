using System.Reflection.Metadata.Ecma335;
using Microsoft.Win32.SafeHandles;

public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public abstract double GetArea();



}