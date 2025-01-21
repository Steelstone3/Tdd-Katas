public class Shape
{
    public virtual double Area(double length, double width)
    {
        return length * width;
    }
}

public class Triangle : Shape
{
    public override double Area(double length, double width)
    {
        return length * width / 2;
    }
}