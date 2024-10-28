public class Circle : Shape
{

    public double Radius { get; set; }
    

    public Circle(string color, double radius) : base(color)
    {
        Radius  = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI *(Radius*Radius);
        return area;
    }

}