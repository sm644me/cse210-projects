using System;

// Define a Square class, which
// should be self-explanatory.
public class Square : Shape
{
    // Member variables begin with an underscore.
    private double _side = 0;

    // Constructor method.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Display relevant information.
    public override double GetArea()
    {
        return _side * _side;
    }
}