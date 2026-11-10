using System;

// Define a Circle class, which
// should be self-explanatory.
public class Circle : Shape
{
    // Member variables begin with an underscore.
    private double _radius = 0;

    // Constructor method.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Display relevant information.
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}