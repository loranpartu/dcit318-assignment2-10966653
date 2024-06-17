// Abstract Classes and Methods
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
