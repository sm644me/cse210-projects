using System;

// Define a Rectangle class, which
// should be self-explanatory.
public class Rectangle : Shape
{
    // Member variables begin with an underscore.
    private double _length = 0;
    private double _width = 0;

    // Constructor method.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Display relevant information.
    public override double GetArea()
    {
        return _length * _width;
    }
}