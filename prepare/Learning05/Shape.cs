using System;

// Define a Shape class, which
// contains generic info.
public abstract class Shape
{
    // Member variables begin with an underscore.
    private string _color = "";

    // Constructor method.
    public Shape(string color)
    {
        _color = color;
    }

    // Display relevant information.
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}